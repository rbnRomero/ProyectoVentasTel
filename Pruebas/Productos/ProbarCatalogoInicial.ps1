param([switch]$Sql)
$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Drawing
$raiz = Split-Path (Split-Path $PSScriptRoot -Parent) -Parent
$datos = Get-Content (Join-Path $raiz 'ScriptsBD/PRODUCTOS_INICIALES_FUENTES.json') -Raw -Encoding UTF8 | ConvertFrom-Json
$carpeta = Join-Path $raiz 'ProyectoVentasTel/img/productos'
$script:comprobaciones = 0
function Afirmar([bool]$condicion, [string]$caso) {
    if (-not $condicion) { throw $caso }
    $script:comprobaciones++
}
Afirmar ($datos.Count -eq 50) 'Deben existir 50 productos.'
Afirmar (@($datos | Where-Object TipoProducto -eq Telefono).Count -eq 25) 'Deben existir 25 teléfonos.'
Afirmar (@($datos | Where-Object TipoProducto -eq Accesorio).Count -eq 25) 'Deben existir 25 accesorios.'
Afirmar (@($datos.Codigo | Select-Object -Unique).Count -eq 50) 'Los códigos deben ser únicos.'
Afirmar (@($datos | Where-Object TipoProducto -eq Telefono | Select-Object -ExpandProperty Modelo -Unique).Count -eq 25) 'Los teléfonos deben ser modelos distintos.'
Afirmar (@(Get-ChildItem $carpeta -File | Where-Object Extension -in '.jpg','.png').Count -eq 50) 'Deben existir exactamente 50 imágenes.'
$textoSql = Get-Content (Join-Path $raiz 'ScriptsBD/3_PRODUCTOS_INICIALES.sql') -Raw -Encoding UTF8
Afirmar ([regex]::Matches($textoSql, "(?m)^    \(N'(?:TEL|ACC)-\d{3}'").Count -eq 50) 'El SQL debe contener exactamente 50 filas de catálogo.'
foreach ($p in $datos) {
    $ruta = Join-Path $carpeta $p.ArchivoImagen
    Afirmar (Test-Path -LiteralPath $ruta -PathType Leaf) ('Falta la imagen ' + $p.Codigo)
    Afirmar ((Get-FileHash -LiteralPath $ruta -Algorithm SHA256).Hash -eq $p.Sha256) ('La imagen cambió: ' + $p.Codigo)
    Afirmar ($p.PaginaProducto -match '^https://www\.(samsung|belkin)\.com/' -and $p.UrlImagen -match '^https://(images\.samsung\.com|s3\.belkin\.com)/') ('Origen no oficial: '+$p.Codigo)
    Afirmar ($p.Codigo.Length -le 30 -and $p.Nombre.Length -le 100 -and $p.Modelo.Length -le 80 -and $p.Color.Length -le 30 -and $p.PrecioVenta -gt 0) ('Datos inválidos: '+$p.Codigo)
    Afirmar (($p.TipoProducto -eq 'Telefono' -and $p.CapacidadGB -gt 0) -or ($p.TipoProducto -eq 'Accesorio' -and $null -eq $p.CapacidadGB)) ('Capacidad inválida: '+$p.Codigo)
    $campos = @($p.Codigo, $p.Nombre, $p.TipoProducto, $p.Marca, $p.Modelo) | ForEach-Object { "N'" + $_.Replace("'", "''") + "'" }
    $capacidad = if ($null -eq $p.CapacidadGB) { 'NULL' } else { [string]$p.CapacidadGB }
    $precio = ([decimal]$p.PrecioVenta).ToString('0.00',[Globalization.CultureInfo]::InvariantCulture)
    $filaEsperada = '(' + ($campos -join ', ') + ', ' + $capacidad + ", N'" + $p.Color.Replace("'", "''") + "', " + $precio + ", N'" + $p.ArchivoImagen + "')"
    Afirmar ($textoSql.Contains($filaEsperada)) ('El SQL debe coincidir con la ficha documentada: '+$p.Codigo)
    $imagen = [Drawing.Bitmap]::FromFile($ruta)
    try {
        Afirmar ($imagen.Width -eq $p.Ancho -and $imagen.Height -eq $p.Alto -and $imagen.Width -ge 300 -and $imagen.Height -ge 300) ('Dimensiones inválidas: '+$p.Codigo)
        foreach ($punto in @(@(0,0),@(($imagen.Width-1),0),@(0,($imagen.Height-1)),@(($imagen.Width-1),($imagen.Height-1)))) {
            $color = $imagen.GetPixel($punto[0],$punto[1])
            Afirmar ($color.A -eq 255 -and $color.R -ge 245 -and $color.G -ge 245 -and $color.B -ge 245) ('El fondo debe ser blanco y opaco: '+$p.Codigo)
        }
    } finally { $imagen.Dispose() }
}
if ($Sql) {
    Add-Type -AssemblyName System.Data
    $configuracion = [xml](Get-Content (Join-Path $raiz 'ProyectoVentasTel/App.config') -Raw)
    $cadena = ($configuracion.configuration.connectionStrings.add | Where-Object name -eq VentasTel_BD).connectionString
    $conexion = New-Object System.Data.SqlClient.SqlConnection $cadena
    $conexion.Open()
    function Ejecutar([string]$texto) {
        $comando = $conexion.CreateCommand()
        try {
            $comando.CommandText = $texto
            $comando.CommandTimeout = 30
            if ($texto -match '@CarpetaImagenes' -and $texto -notmatch 'DECLARE @CarpetaImagenes') {
                $comando.Parameters.Add('@CarpetaImagenes',[Data.SqlDbType]::NVarChar,500).Value = $carpeta
            }
            $tabla = New-Object Data.DataTable
            $adaptador = New-Object Data.SqlClient.SqlDataAdapter $comando
            try { [void]$adaptador.Fill($tabla) } finally { $adaptador.Dispose() }
            return ,$tabla
        } finally { $comando.Dispose() }
    }
    $sqlOriginal = Get-Content (Join-Path $raiz 'ScriptsBD/3_PRODUCTOS_INICIALES.sql') -Raw -Encoding UTF8
    $sqlCarga = [regex]::Replace($sqlOriginal, '(?m)^USE VentasTel_BD;\r?\nGO\r?\n', '')
    $sqlCarga = [regex]::Replace($sqlCarga, '(?m)^DECLARE @CarpetaImagenes NVARCHAR\(500\) = .*;\r?\n', '')
    $sqlCarga = $sqlCarga.Replace("OBJECT_ID(N'dbo.Productos', N'U')", "OBJECT_ID(N'tempdb..#Productos', N'U')").Replace('dbo.Productos','#Productos')
    $esquema = Get-Content (Join-Path $raiz 'ScriptsBD/2_TABLAS.sql') -Raw -Encoding UTF8
    $crear = [regex]::Match($esquema,'(?s)CREATE TABLE dbo\.Productos \(.*?\);').Value.Replace('dbo.Productos','#Productos')
    if (-not $crear) { throw 'No se encontró el esquema de Productos.' }
    # Se prueba el SQL entregado con el esquema real en una tabla temporal.
    # Cada escenario se revierte; dbo.Productos nunca se modifica.
    $preparar = 'SET ANSI_NULLS ON; SET ANSI_PADDING ON; SET ANSI_WARNINGS ON; SET ARITHABORT ON; SET CONCAT_NULL_YIELDS_NULL ON; SET QUOTED_IDENTIFIER ON; SET NUMERIC_ROUNDABORT OFF; BEGIN TRANSACTION; ' + $crear + " CREATE UNIQUE INDEX UX_PruebaVariante ON #Productos(Marca,Modelo,CapacidadGB,Color) WHERE TipoProducto='Telefono';"
    $revertir = 'IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;'
    try {
        $antes = (Ejecutar 'SELECT COUNT(*) AS Total FROM dbo.Productos;').Rows[0].Total
        [void](Ejecutar $preparar)
        try {
            $resumen = Ejecutar $sqlCarga
            Afirmar ($resumen.Rows.Count -eq 2 -and ($resumen.Rows | Measure-Object Insertados -Sum).Sum -eq 50) 'La primera carga debe insertar 50.'
            $conteo = Ejecutar "SELECT COUNT(*) AS Total FROM #Productos WHERE Existencias=0 AND Activo=1 AND RutaImagen LIKE @CarpetaImagenes + N'%';"
            Afirmar ($conteo.Rows[0].Total -eq 50) 'Las 50 rutas, estados y existencias deben ser válidos.'
            $tipos = Ejecutar 'SELECT TipoProducto,COUNT(*) AS Total FROM #Productos GROUP BY TipoProducto;'
            Afirmar ($tipos.Rows.Count -eq 2 -and $tipos.Rows[0].Total -eq 25 -and $tipos.Rows[1].Total -eq 25) 'La carga debe ser 25/25.'
            foreach ($p in $datos) {
                $fila = (Ejecutar ("SELECT * FROM #Productos WHERE Codigo=N'"+$p.Codigo+"';")).Rows[0]
                Afirmar ($fila.Nombre -eq $p.Nombre -and $fila.Modelo -eq $p.Modelo -and $fila.Color -eq $p.Color -and $fila.RutaImagen -eq (Join-Path $carpeta $p.ArchivoImagen)) ('SQL e imágenes deben coincidir: '+$p.Codigo)
            }
            [void](Ejecutar "UPDATE #Productos SET Nombre=N'Editado',PrecioVenta=123.45,Existencias=7,Activo=0,RutaImagen=N'anterior.png' WHERE Codigo='TEL-001';")
            $repetido = Ejecutar $sqlCarga
            Afirmar (($repetido.Rows | Measure-Object Insertados -Sum).Sum -eq 0 -and ($repetido.Rows | Measure-Object Omitidos -Sum).Sum -eq 50) 'Repetir debe omitir 50.'
            $fila = (Ejecutar "SELECT * FROM #Productos WHERE Codigo='TEL-001';").Rows[0]
            Afirmar ($fila.Nombre -eq 'Editado' -and $fila.PrecioVenta -eq 123.45 -and $fila.Existencias -eq 7 -and -not $fila.Activo -and $fila.RutaImagen -eq 'anterior.png') 'Repetir debe conservar las ediciones.'
            [void](Ejecutar "DELETE FROM #Productos WHERE Codigo='ACC-025';")
            $parcial = Ejecutar $sqlCarga
            Afirmar (($parcial.Rows | Measure-Object Insertados -Sum).Sum -eq 1 -and ($parcial.Rows | Measure-Object Omitidos -Sum).Sum -eq 49) 'Una carga parcial debe insertar solo el faltante.'
        } finally { [void](Ejecutar $revertir) }
        foreach ($caso in @('Codigo','Variante')) {
            [void](Ejecutar $preparar)
            try {
                [void](Ejecutar $sqlCarga)
                if ($caso -eq 'Codigo') { [void](Ejecutar "UPDATE #Productos SET Modelo=N'OTRO-MODELO' WHERE Codigo='TEL-001';") }
                else { [void](Ejecutar "UPDATE #Productos SET Codigo=N'OTRO-CODIGO' WHERE Codigo='TEL-001';") }
                $rechazado = $false
                try { [void](Ejecutar $sqlCarga) } catch {
                    $excepcion = $_.Exception
                    while ($excepcion.InnerException) { $excepcion = $excepcion.InnerException }
                    $esperado = if ($caso -eq 'Codigo') { 51001 } else { 51002 }
                    if ($excepcion -is [Data.SqlClient.SqlException] -and $excepcion.Number -eq $esperado) { $rechazado = $true } else { throw }
                }
                Afirmar $rechazado ('Debe rechazar el conflicto de '+$caso)
                Afirmar ((Ejecutar 'SELECT @@TRANCOUNT AS Total;').Rows[0].Total -eq 0) 'El conflicto debe revertir la transacción completa.'
            } finally { [void](Ejecutar $revertir) }
        }
        Afirmar ((Ejecutar 'SELECT COUNT(*) AS Total FROM dbo.Productos;').Rows[0].Total -eq $antes) 'Los productos reales deben permanecer intactos.'
    } finally { $conexion.Dispose() }
}
Write-Output ('Correcto: '+$script:comprobaciones+' comprobaciones del catálogo'+$(if($Sql){' e inserción SQL revertida.'}else{'.'}))

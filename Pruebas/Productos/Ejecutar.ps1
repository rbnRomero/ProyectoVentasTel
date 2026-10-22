param([switch]$Sql, [switch]$Vista, [ValidateSet('Debug', 'Release')][string]$Configuracion = 'Debug')
$ErrorActionPreference = 'Stop'
$raizProyecto = Split-Path (Split-Path $PSScriptRoot -Parent) -Parent
$salidaPruebas = Join-Path $raizProyecto "ProyectoVentasTel\bin\$Configuracion"
$compilador = Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'
$ejecutable = Join-Path $salidaPruebas 'PruebasProductos.exe'
& $compilador /nologo /target:exe /out:$ejecutable /reference:"$salidaPruebas\ProyectoVentasTel.exe" /reference:System.Data.dll /reference:System.Drawing.dll /reference:System.Windows.Forms.dll /reference:System.Transactions.dll (Join-Path $PSScriptRoot 'PruebasProductos.cs')
if ($LASTEXITCODE -ne 0) { throw 'No se pudieron compilar las pruebas.' }
Copy-Item -LiteralPath (Join-Path $salidaPruebas 'ProyectoVentasTel.exe.config') -Destination "$ejecutable.config" -Force
if ($Vista) { & $ejecutable --vista } elseif ($Sql) { & $ejecutable --sql } else { & $ejecutable }
if ($LASTEXITCODE -ne 0) { throw 'Fallaron las pruebas de productos.' }

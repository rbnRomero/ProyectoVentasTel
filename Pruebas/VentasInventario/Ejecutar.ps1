param([ValidateSet('Debug', 'Release')][string]$Configuracion = 'Debug')
$ErrorActionPreference = 'Stop'
$raiz = Split-Path (Split-Path $PSScriptRoot -Parent) -Parent
$salida = Join-Path $raiz "ProyectoVentasTel\bin\$Configuracion"
$csc = Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'
$exe = Join-Path $salida 'PruebasVentasInventario.exe'
& $csc /nologo /target:exe /out:$exe /reference:"$salida\ProyectoVentasTel.exe" (Join-Path $PSScriptRoot 'PruebasFlujos.cs')
if ($LASTEXITCODE -ne 0) { throw 'No se pudieron compilar las pruebas de Ventas e Inventario.' }
Copy-Item -LiteralPath (Join-Path $salida 'ProyectoVentasTel.exe.config') -Destination "$exe.config" -Force
& $exe
if ($LASTEXITCODE -ne 0) { throw 'Fallaron las pruebas de Ventas e Inventario.' }

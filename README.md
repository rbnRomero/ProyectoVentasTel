# VISOR — Ventas e inventario

Aplicación escolar de escritorio para gestionar ventas e inventario de teléfonos y accesorios, desarrollada en VB.NET y Windows Forms.

## Requisitos y ejecución

- Visual Studio con desarrollo de escritorio .NET, MSBuild y el paquete de destino de .NET Framework 4.8.
- SQL Server o SQL Server Express LocalDB y una herramienta para ejecutar scripts T-SQL.
- Ejecutar primero `ScriptsBD/1_CREACION_BD.sql` y después `ScriptsBD/2_TABLAS.sql`.
- Configurar la conexión `VentasTel_BD` en `ProyectoVentasTel/App.config` para la instancia local. No versionar credenciales reales.
- Desde una consola de desarrollador de Visual Studio, compilar con `msbuild ProyectoVentasTel.slnx /p:Configuration=Debug`.
- Ejecutar `.\ProyectoVentasTel\bin\Debug\ProyectoVentasTel.exe`.

## Productos

El módulo consulta, agrega y edita registros de `dbo.Productos`; no modifica otras tablas ni requiere cambios de esquema.

Administrador e Inventarios pueden agregar y editar. Vendedor solo consulta. La búsqueda encuentra coincidencias parciales de código, nombre, marca o modelo y se combina con los filtros de tipo y estado. Ambos filtros inician en Todos.

Código y nombre son obligatorios. Los teléfonos requieren marca, modelo, capacidad entera positiva en GB y color; los accesorios no almacenan capacidad. El precio debe ser positivo, con hasta dos decimales y un máximo de 9,999,999,999.99. Se respetan las longitudes del esquema y la comparación de texto de SQL Server. Los códigos y las variantes de teléfono (marca, modelo, capacidad y color) son únicos, incluso para productos inactivos.

Las existencias son de solo lectura: los productos nuevos empiezan en cero. Las entradas y ventas deben gestionar los movimientos de stock en sus módulos correspondientes. Desactivar un producto conserva sus datos; no se permite eliminación física. Si dos usuarios editan simultáneamente, prevalece el último guardado de los datos del catálogo, sin sobrescribir existencias.

Las imágenes JPEG y PNG se validan y copian al guardar en `ProyectoVentasTel/img/productos`, dentro del proyecto de código fuente, con nombres únicos y codificación PNG. La aplicación busca la carpeta que contiene `ProyectoVentasTel.vbproj` ascendiendo desde el directorio del ejecutable; Debug y Release usan la misma carpeta, independientemente del directorio de trabajo. Si `img/productos` no existe, se crea automáticamente. Se requiere que el proyecto esté disponible y que el usuario tenga permisos de escritura; si falta o no se puede escribir, se informa el error y el producto no se guarda. No se utiliza una ubicación alternativa automática.

`RutaImagen` almacena la ruta absoluta de la copia. Las imágenes anteriores siguen cargándose desde sus rutas almacenadas y no se migran automáticamente. Cancelar no copia archivos; un fallo de persistencia intenta eliminar la nueva copia. Quitar o reemplazar desvincula la imagen anterior sin borrar su archivo. Si un archivo falta o está dañado, se muestra Sin imagen. Las imágenes no se sincronizan automáticamente entre equipos.

## Catálogo inicial de 50 productos

`ScriptsBD/3_PRODUCTOS_INICIALES.sql` agrega 25 modelos distintos de teléfonos Samsung y 25 accesorios Samsung y Belkin. Los precios son ilustrativos en MXN; todos se crean activos y con existencias en cero. No registra entradas de inventario ni modifica el esquema.

1. Ejecutar primero `ScriptsBD/1_CREACION_BD.sql` y `ScriptsBD/2_TABLAS.sql`.
2. Comprobar que las 50 fotografías estén en `ProyectoVentasTel/img/productos`. Sus nombres coinciden con los códigos `TEL-001` a `TEL-025` y `ACC-001` a `ACC-025`; se conservan en JPEG o PNG sin editar el fondo.
3. Abrir `ScriptsBD/3_PRODUCTOS_INICIALES.sql` en SSMS y reemplazar el valor de `@CarpetaImagenes` por la ruta absoluta de esa carpeta en el equipo que ejecutará VISOR. Por ejemplo: `N'C:\Repos\ProyectoVentasTel\ProyectoVentasTel\img\productos'`.
4. Ejecutar el script completo. Al terminar muestra insertados y omitidos por tipo. No requiere activar el modo SQLCMD.

La carga es transaccional y puede repetirse. Un código existente se omite cuando coincide su tipo, marca, modelo, capacidad y color; conserva nombre, precio, estado, ruta y existencias, aunque se hayan editado. Si el código pertenece a otro producto o una variante de teléfono ya existe con otro código, revierte la carga completa. Los productos inactivos también participan en estas comprobaciones.

SQL Server no descarga imágenes ni valida archivos del equipo cliente. Las fotos ya están incluidas en el proyecto y fueron revisadas visualmente: producto aislado, fondo blanco, sin personas, ambientación, empaques ni teléfonos dentro de las fundas. Para evitar textos promocionales en pantalla se usan vistas traseras de algunos teléfonos. El soporte Belkin aparece sin teléfono y los audífonos muestran sus propios componentes. Las páginas oficiales, URL exacta de cada fotografía, dimensiones y SHA-256 están documentadas en `ScriptsBD/PRODUCTOS_INICIALES_FUENTES.json`.

## Comprobación antes de la entrega

Compila la solución en Debug desde una consola de desarrollador de Visual Studio:

```powershell
msbuild ProyectoVentasTel.slnx /p:Configuration=Debug
```

Ejecuta la aplicación compilada:

```powershell
.\ProyectoVentasTel\bin\Debug\ProyectoVentasTel.exe
```

Con la base de datos preparada, comprueba manualmente el inicio de sesión, los permisos por rol y los módulos de productos, ventas e inventario. Verifica altas, ediciones y consultas de productos; registro de entradas; confirmación, historial y cancelación de ventas; validaciones; actualización de existencias; e imágenes de productos. Confirma también que la aplicación muestre un mensaje claro si no puede conectarse a SQL Server.

Para revisar la configuración optimizada, compila también Release con `msbuild ProyectoVentasTel.slnx /p:Configuration=Release` y abre `ProyectoVentasTel\bin\Release\ProyectoVentasTel.exe`.

## Ventas e inventario

El módulo Ventas consulta productos activos con existencias, prepara un carrito y confirma ventas de contado. La confirmación guarda el folio, encabezado y detalle, y descuenta existencias dentro de una transacción. El historial permite filtrar por fechas y estado y consultar el detalle. Vendedores pueden cancelar sus propias ventas y Administradores cualquiera; se requiere motivo y la devolución de existencias se registra junto con la cancelación en una transacción. Se usan `dbo.Productos`, `dbo.Ventas`, `dbo.DetalleVenta` y `dbo.Usuarios`.

Entradas de inventario permite a los roles Administrador e Inventarios registrar cantidades positivas para productos activos y consultar el historial. El incremento de existencias y el registro en `dbo.EntradasInventario` se confirman juntos. Se usan `dbo.Productos`, `dbo.EntradasInventario` y `dbo.Usuarios`. No requiere cambios de esquema.

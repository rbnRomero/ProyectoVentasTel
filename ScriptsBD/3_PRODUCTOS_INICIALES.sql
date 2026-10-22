USE VentasTel_BD;
GO

-- Ejecutar después de 1_CREACION_BD.sql y 2_TABLAS.sql, desde SSMS.
-- Cambiar esta única variable por la ruta ABSOLUTA de la carpeta del proyecto.
-- Los precios son ejemplos en MXN; no son cotizaciones del fabricante.
DECLARE @CarpetaImagenes NVARCHAR(500) = N'CAMBIAR_RUTA_ABSOLUTA\ProyectoVentasTel\img\productos';

SET NOCOUNT ON;
SET XACT_ABORT ON;
SET ANSI_NULLS ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET QUOTED_IDENTIFIER ON;
SET NUMERIC_ROUNDABORT OFF;

SET @CarpetaImagenes = REPLACE(LTRIM(RTRIM(@CarpetaImagenes)), N'/', N'\');
WHILE RIGHT(@CarpetaImagenes, 1) = N'\'
    SET @CarpetaImagenes = LEFT(@CarpetaImagenes, LEN(@CarpetaImagenes) - 1);

IF @CarpetaImagenes IS NULL OR @CarpetaImagenes = N''
   OR @CarpetaImagenes LIKE N'%CAMBIAR_RUTA_ABSOLUTA%'
   OR NOT (@CarpetaImagenes LIKE N'[A-Za-z]:\%' OR LEFT(@CarpetaImagenes, 2) = N'\\')
    THROW 51000, N'Indica la ruta absoluta de img/productos en @CarpetaImagenes antes de ejecutar el script.', 1;
IF LEN(@CarpetaImagenes) + 12 > 500
    THROW 51000, N'La ruta de las imágenes excede la longitud admitida por Productos.RutaImagen.', 1;
IF OBJECT_ID(N'dbo.Productos', N'U') IS NULL
    THROW 51000, N'Primero ejecuta los scripts de creación de la base y sus tablas.', 1;

-- Las imágenes ya se entregan con el proyecto. SQL Server no descarga archivos
-- ni comprueba rutas del equipo cliente; revisar la carpeta antes de ejecutar.
DECLARE @Catalogo TABLE (
    Codigo NVARCHAR(30) NOT NULL PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    TipoProducto VARCHAR(10) NOT NULL,
    Marca NVARCHAR(50) NOT NULL,
    Modelo NVARCHAR(80) NOT NULL,
    CapacidadGB INT NULL,
    Color NVARCHAR(30) NOT NULL,
    PrecioVenta DECIMAL(12,2) NOT NULL,
    ArchivoImagen NVARCHAR(30) NOT NULL
);

INSERT INTO @Catalogo
    (Codigo, Nombre, TipoProducto, Marca, Modelo, CapacidadGB, Color, PrecioVenta, ArchivoImagen)
VALUES
    (N'TEL-001', N'Galaxy F13 4GB', N'Telefono', N'Samsung', N'SM-E135F/DS', 64, N'Azul', 3999.00, N'TEL-001.jpg'),
    (N'TEL-002', N'Galaxy A15 5G', N'Telefono', N'Samsung', N'SM-A156E/DS', 128, N'Azul claro', 5999.00, N'TEL-002.jpg'),
    (N'TEL-003', N'Galaxy S24', N'Telefono', N'Samsung', N'SM-S921B/DS', 256, N'Amarillo ambar', 15999.00, N'TEL-003.jpg'),
    (N'TEL-004', N'Galaxy S24 Ultra', N'Telefono', N'Samsung', N'SM-S928B/DS', 256, N'Gris titanio', 22999.00, N'TEL-004.jpg'),
    (N'TEL-005', N'Galaxy F15 5G', N'Telefono', N'Samsung', N'SM-E156B/DS', 128, N'Negro', 3999.00, N'TEL-005.jpg'),
    (N'TEL-006', N'Galaxy A55 5G', N'Telefono', N'Samsung', N'SM-A556E/DS', 256, N'Azul hielo', 5999.00, N'TEL-006.jpg'),
    (N'TEL-007', N'Galaxy A35 5G', N'Telefono', N'Samsung', N'SM-A356E/DS', 128, N'Azul marino', 5999.00, N'TEL-007.jpg'),
    (N'TEL-008', N'Galaxy M55 5G', N'Telefono', N'Samsung', N'SM-M556B/DS', 128, N'Verde claro', 3999.00, N'TEL-008.jpg'),
    (N'TEL-009', N'Galaxy F55 5G', N'Telefono', N'Samsung', N'SM-E556B/DS', 128, N'Negro', 3999.00, N'TEL-009.jpg'),
    (N'TEL-010', N'Galaxy Z Flip6', N'Telefono', N'Samsung', N'SM-F741B', 256, N'Negro texturizado', 18999.00, N'TEL-010.jpg'),
    (N'TEL-011', N'Galaxy Z Fold6', N'Telefono', N'Samsung', N'SM-F956B/DS', 256, N'Plata', 28999.00, N'TEL-011.jpg'),
    (N'TEL-012', N'Galaxy M35 5G', N'Telefono', N'Samsung', N'SM-M356B/DS', 128, N'Azul claro', 3999.00, N'TEL-012.jpg'),
    (N'TEL-013', N'Galaxy A06', N'Telefono', N'Samsung', N'SM-A065F/DS', 64, N'Azul claro', 5999.00, N'TEL-013.jpg'),
    (N'TEL-014', N'Galaxy M15 5G Prime', N'Telefono', N'Samsung', N'SM-M156B/DS', 128, N'Azul oscuro', 3999.00, N'TEL-014.jpg'),
    (N'TEL-015', N'Galaxy M05', N'Telefono', N'Samsung', N'SM-M055F/DS', 64, N'Menta', 3999.00, N'TEL-015.jpg'),
    (N'TEL-016', N'Galaxy F05', N'Telefono', N'Samsung', N'SM-E055F/DS', 64, N'Azul cuarzo', 3999.00, N'TEL-016.jpg'),
    (N'TEL-017', N'Galaxy M55s 5G', N'Telefono', N'Samsung', N'SM-M558B/DS', 256, N'Azul', 3999.00, N'TEL-017.jpg'),
    (N'TEL-018', N'Galaxy S24 FE', N'Telefono', N'Samsung', N'SM-S721B/DS', 128, N'Azul', 15999.00, N'TEL-018.jpg'),
    (N'TEL-019', N'Galaxy A16 5G', N'Telefono', N'Samsung', N'SM-A166P/DS', 128, N'Dorado', 5999.00, N'TEL-019.jpg'),
    (N'TEL-020', N'Galaxy S25', N'Telefono', N'Samsung', N'SM-S931B/DS', 256, N'Azul hielo', 15999.00, N'TEL-020.jpg'),
    (N'TEL-021', N'Galaxy S25 Ultra', N'Telefono', N'Samsung', N'SM-S938B/DS', 256, N'Gris titanio', 22999.00, N'TEL-021.jpg'),
    (N'TEL-022', N'Galaxy XCover7 EE', N'Telefono', N'Samsung', N'SM-G556B', 128, N'Negro', 3999.00, N'TEL-022.jpg'),
    (N'TEL-023', N'Galaxy F06 5G', N'Telefono', N'Samsung', N'SM-E066B/DS', 128, N'Azul', 3999.00, N'TEL-023.jpg'),
    (N'TEL-024', N'Galaxy F16 5G', N'Telefono', N'Samsung', N'SM-E166P/DS', 128, N'Azul ceruleo', 3999.00, N'TEL-024.jpg'),
    (N'TEL-025', N'Galaxy M06 5G', N'Telefono', N'Samsung', N'SM-M066B/DS', 128, N'Mystic Black', 3999.00, N'TEL-025.jpg'),
    (N'ACC-001', N'Cable USB-C a USB-C 5A EP-DN975', N'Accesorio', N'Samsung', N'EP-DN975', NULL, N'Negro', 399.00, N'ACC-001.jpg'),
    (N'ACC-002', N'Cargador Trio de 65W', N'Accesorio', N'Samsung', N'EP-T6530', NULL, N'Negro', 1299.00, N'ACC-002.jpg'),
    (N'ACC-003', N'Cargador inalámbrico Duo', N'Accesorio', N'Samsung', N'EP-P5400', NULL, N'Gris oscuro', 1599.00, N'ACC-003.jpg'),
    (N'ACC-004', N'Cargador USB-C de 15W', N'Accesorio', N'Samsung', N'EP-T1510', NULL, N'Negro', 349.00, N'ACC-004.jpg'),
    (N'ACC-005', N'Cargador para auto de 40W', N'Accesorio', N'Samsung', N'EP-L4020', NULL, N'Negro', 799.00, N'ACC-005.jpg'),
    (N'ACC-006', N'Cable USB-C a USB-C 3A EP-DX310', N'Accesorio', N'Samsung', N'EP-DX310', NULL, N'Negro', 299.00, N'ACC-006.jpg'),
    (N'ACC-007', N'Cable USB-C a USB-C 5A EP-DX510', N'Accesorio', N'Samsung', N'EP-DX510', NULL, N'Negro', 449.00, N'ACC-007.jpg'),
    (N'ACC-008', N'Audífonos USB-C EO-IC100', N'Accesorio', N'Samsung', N'EO-IC100', NULL, N'Negro', 599.00, N'ACC-008.jpg'),
    (N'ACC-009', N'Batería externa 10000mAh de 25W', N'Accesorio', N'Samsung', N'EB-P3400', NULL, N'Beige', 999.00, N'ACC-009.jpg'),
    (N'ACC-010', N'Localizador Galaxy SmartTag2', N'Accesorio', N'Samsung', N'EI-T5600', NULL, N'Negro', 649.00, N'ACC-010.jpg'),
    (N'ACC-011', N'Cargador USB-C de 25W', N'Accesorio', N'Samsung', N'EP-T2510', NULL, N'Negro', 599.00, N'ACC-011.jpg'),
    (N'ACC-012', N'Funda de silicona para Galaxy S24', N'Accesorio', N'Samsung', N'EF-PS921', NULL, N'Lima', 699.00, N'ACC-012.jpg'),
    (N'ACC-013', N'Funda de silicona para Galaxy S24+', N'Accesorio', N'Samsung', N'EF-PS926', NULL, N'White', 899.00, N'ACC-013.jpg'),
    (N'ACC-014', N'Soporte para auto Car Vent Mount PRO con MagSafe', N'Accesorio', N'Belkin', N'WIC002btGR', NULL, N'Plata', 899.00, N'ACC-014.png'),
    (N'ACC-015', N'Funda Vegan Leather para Galaxy S24', N'Accesorio', N'Samsung', N'GP-FPS921HCA', NULL, N'Violeta oscuro', 899.00, N'ACC-015.jpg'),
    (N'ACC-016', N'Funda de silicona para Galaxy A55', N'Accesorio', N'Samsung', N'EF-PA556', NULL, N'Negro', 499.00, N'ACC-016.jpg'),
    (N'ACC-017', N'Funda transparente para Galaxy A55', N'Accesorio', N'Samsung', N'EF-QA556', NULL, N'Transparente', 349.00, N'ACC-017.jpg'),
    (N'ACC-018', N'Protector de pantalla para Galaxy A35 (2 piezas)', N'Accesorio', N'Samsung', N'EF-UA356', NULL, N'Transparente', 299.00, N'ACC-018.jpg'),
    (N'ACC-019', N'Batería externa 20000mAh de 45W', N'Accesorio', N'Samsung', N'EB-P4520', NULL, N'Beige', 1499.00, N'ACC-019.jpg'),
    (N'ACC-020', N'Cargador Super Fast de 45W', N'Accesorio', N'Samsung', N'EP-T4511', NULL, N'Negro', 999.00, N'ACC-020.jpg'),
    (N'ACC-021', N'Batería externa inalámbrica 10000mAh de 25W', N'Accesorio', N'Samsung', N'EB-U2510', NULL, N'Beige', 1299.00, N'ACC-021.jpg'),
    (N'ACC-022', N'Funda transparente para Galaxy Z Flip6', N'Accesorio', N'Samsung', N'GP-FFF741YCA', NULL, N'Transparente', 699.00, N'ACC-022.jpg'),
    (N'ACC-023', N'Cargador Duo de 50W', N'Accesorio', N'Samsung', N'EP-T5020', NULL, N'Negro', 1199.00, N'ACC-023.jpg'),
    (N'ACC-024', N'Funda Vegan Leather para Galaxy S24+', N'Accesorio', N'Samsung', N'GP-FPS926HCA', NULL, N'Taupe', 999.00, N'ACC-024.jpg'),
    (N'ACC-025', N'Funda transparente para Galaxy S25', N'Accesorio', N'Samsung', N'EF-QS931', NULL, N'Transparente', 499.00, N'ACC-025.jpg');

IF (SELECT COUNT(*) FROM @Catalogo WHERE TipoProducto = 'Telefono') <> 25
   OR (SELECT COUNT(*) FROM @Catalogo WHERE TipoProducto = 'Accesorio') <> 25
   OR (SELECT COUNT(*) FROM @Catalogo) <> 50
    THROW 51000, N'El catálogo debe contener exactamente 25 teléfonos y 25 accesorios.', 1;
IF EXISTS (SELECT 1 FROM @Catalogo WHERE PrecioVenta <= 0
    OR (TipoProducto = 'Telefono' AND (CapacidadGB IS NULL OR CapacidadGB <= 0))
    OR (TipoProducto = 'Accesorio' AND CapacidadGB IS NOT NULL))
    THROW 51000, N'Hay un precio o una capacidad inválida en el catálogo.', 1;
IF EXISTS (SELECT 1 FROM @Catalogo WHERE TipoProducto = 'Telefono'
    GROUP BY Marca, Modelo, CapacidadGB, Color HAVING COUNT(*) > 1)
    THROW 51000, N'El catálogo contiene variantes de teléfono repetidas.', 1;

DECLARE @Insertados TABLE (TipoProducto VARCHAR(10) NOT NULL);
BEGIN TRY
    BEGIN TRANSACTION;

    -- El código identifica el mismo tipo, marca, modelo, capacidad y color.
    -- Nombre, precio, estado, ruta y existencias pueden haber sido editados:
    -- una repetición de la carga nunca sobrescribe esos datos.
    IF EXISTS (
        SELECT 1 FROM @Catalogo AS c
        INNER JOIN dbo.Productos AS p WITH (UPDLOCK, HOLDLOCK) ON p.Codigo = c.Codigo
        WHERE EXISTS (
            SELECT p.TipoProducto, p.Marca, p.Modelo, p.CapacidadGB, p.Color
            EXCEPT
            SELECT c.TipoProducto, c.Marca, c.Modelo, c.CapacidadGB, c.Color
        )
    )
        THROW 51001, N'Un código del catálogo ya pertenece a otro producto. No se insertó ningún registro.', 1;

    IF EXISTS (
        SELECT 1 FROM @Catalogo AS c
        INNER JOIN dbo.Productos AS p WITH (UPDLOCK, HOLDLOCK)
            ON p.TipoProducto = 'Telefono' AND c.TipoProducto = 'Telefono'
            AND p.Marca = c.Marca AND p.Modelo = c.Modelo
            AND p.CapacidadGB = c.CapacidadGB AND p.Color = c.Color
        WHERE p.Codigo <> c.Codigo
    )
        THROW 51002, N'Una variante de teléfono ya existe con otro código. No se insertó ningún registro.', 1;

    INSERT INTO dbo.Productos
        (Codigo, Nombre, TipoProducto, Marca, Modelo, CapacidadGB, Color, PrecioVenta, Existencias, RutaImagen, Activo)
    OUTPUT inserted.TipoProducto INTO @Insertados (TipoProducto)
    SELECT c.Codigo, c.Nombre, c.TipoProducto, c.Marca, c.Modelo, c.CapacidadGB,
           c.Color, c.PrecioVenta, 0, @CarpetaImagenes + N'\' + c.ArchivoImagen, 1
    FROM @Catalogo AS c
    WHERE NOT EXISTS (
        SELECT 1 FROM dbo.Productos AS p WITH (UPDLOCK, HOLDLOCK) WHERE p.Codigo = c.Codigo
    );

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;

SELECT c.TipoProducto AS Tipo,
       COUNT(*) AS ProductosCatalogo,
       (SELECT COUNT(*) FROM @Insertados AS i WHERE i.TipoProducto = c.TipoProducto) AS Insertados,
       COUNT(*) - (SELECT COUNT(*) FROM @Insertados AS i WHERE i.TipoProducto = c.TipoProducto) AS Omitidos
FROM @Catalogo AS c
GROUP BY c.TipoProducto
ORDER BY c.TipoProducto;

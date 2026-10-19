USE VentasTel_BD;
GO

-- Opciones necesarias para el indice unico de telefonos.
SET ANSI_NULLS ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET QUOTED_IDENTIFIER ON;
SET NUMERIC_ROUNDABORT OFF;

-- Roles
IF OBJECT_ID(N'dbo.Roles', N'U') IS NULL
CREATE TABLE dbo.Roles (
    IdRol INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(30) NOT NULL UNIQUE
);
GO

-- Usuarios
IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
CREATE TABLE dbo.Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    IdRol INT NOT NULL,
    NombreCompleto NVARCHAR(100) NOT NULL,
    NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
    ContrasenaHash NVARCHAR(255) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,

    FOREIGN KEY (IdRol) REFERENCES dbo.Roles(IdRol)
);
GO

-- Telefonos y accesorios
IF OBJECT_ID(N'dbo.Productos', N'U') IS NULL
CREATE TABLE dbo.Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    Codigo NVARCHAR(30) NOT NULL UNIQUE,
    Nombre NVARCHAR(100) NOT NULL,
    TipoProducto VARCHAR(10) NOT NULL
        CHECK (TipoProducto IN ('Telefono', 'Accesorio')),
    Marca NVARCHAR(50) NULL,
    Modelo NVARCHAR(80) NULL,
    CapacidadGB INT NULL,
    Color NVARCHAR(30) NULL,
    PrecioVenta DECIMAL(12,2) NOT NULL CHECK (PrecioVenta > 0),
    Existencias INT NOT NULL DEFAULT 0 CHECK (Existencias >= 0),
    RutaImagen NVARCHAR(500) NULL,
    Activo BIT NOT NULL DEFAULT 1,

    CHECK (
        (TipoProducto = 'Telefono'
            AND Marca IS NOT NULL AND Modelo IS NOT NULL
            AND CapacidadGB IS NOT NULL AND CapacidadGB > 0
            AND Color IS NOT NULL)
        OR
        (TipoProducto = 'Accesorio' AND CapacidadGB IS NULL)
    )
);
GO

-- Evita registrar dos veces la misma variante de telefono.
IF NOT EXISTS (
    SELECT 1 FROM sys.indexes
    WHERE object_id = OBJECT_ID(N'dbo.Productos')
      AND name = N'UX_Productos_VarianteTelefono'
)
CREATE UNIQUE INDEX UX_Productos_VarianteTelefono
    ON dbo.Productos(Marca, Modelo, CapacidadGB, Color)
    WHERE TipoProducto = 'Telefono';
GO

-- Entradas de inventario
IF OBJECT_ID(N'dbo.EntradasInventario', N'U') IS NULL
CREATE TABLE dbo.EntradasInventario (
    IdEntrada INT IDENTITY(1,1) PRIMARY KEY,
    IdProducto INT NOT NULL,
    IdUsuario INT NOT NULL,
    FechaHora DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    Observaciones NVARCHAR(250) NULL,

    FOREIGN KEY (IdProducto) REFERENCES dbo.Productos(IdProducto),
    FOREIGN KEY (IdUsuario) REFERENCES dbo.Usuarios(IdUsuario)
);
GO

-- Ventas
IF OBJECT_ID(N'dbo.Ventas', N'U') IS NULL
CREATE TABLE dbo.Ventas (
    IdVenta INT IDENTITY(1,1) PRIMARY KEY,
    Folio NVARCHAR(20) NOT NULL UNIQUE,
    IdVendedor INT NOT NULL,
    FechaHora DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    Total DECIMAL(12,2) NOT NULL CHECK (Total > 0),
    EfectivoRecibido DECIMAL(12,2) NOT NULL,
    Estado VARCHAR(10) NOT NULL DEFAULT 'Confirmada'
        CHECK (Estado IN ('Confirmada', 'Cancelada')),
    IdUsuarioCancela INT NULL,
    FechaCancelacion DATETIME2(0) NULL,
    MotivoCancelacion NVARCHAR(250) NULL,

    FOREIGN KEY (IdVendedor) REFERENCES dbo.Usuarios(IdUsuario),
    FOREIGN KEY (IdUsuarioCancela) REFERENCES dbo.Usuarios(IdUsuario),

    CHECK (EfectivoRecibido >= Total),

    CHECK (
        (Estado = 'Confirmada'
            AND IdUsuarioCancela IS NULL
            AND FechaCancelacion IS NULL
            AND MotivoCancelacion IS NULL)
        OR
        (Estado = 'Cancelada'
            AND IdUsuarioCancela IS NOT NULL
            AND FechaCancelacion IS NOT NULL
            AND MotivoCancelacion IS NOT NULL
            AND LEN(LTRIM(RTRIM(MotivoCancelacion))) > 0)
    )
);
GO

-- Productos incluidos en cada venta
IF OBJECT_ID(N'dbo.DetalleVenta', N'U') IS NULL
CREATE TABLE dbo.DetalleVenta (
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
    IdVenta INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    PrecioUnitario DECIMAL(12,2) NOT NULL CHECK (PrecioUnitario > 0),

    FOREIGN KEY (IdVenta) REFERENCES dbo.Ventas(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES dbo.Productos(IdProducto),
    UNIQUE (IdVenta, IdProducto)
);
GO

-- Roles iniciales
INSERT INTO dbo.Roles (Nombre)
SELECT Nombre
FROM (VALUES (N'Administrador'), (N'Vendedor'), (N'Inventarios')) AS NuevosRoles(Nombre)
WHERE NOT EXISTS (
    SELECT 1 FROM dbo.Roles AS Existentes
    WHERE Existentes.Nombre = NuevosRoles.Nombre
);

-- Administrador inicial. La contraseña se almacena exclusivamente como hash PBKDF2-SHA256.
-- La contraseña temporal se entrega fuera del repositorio y debe cambiarse antes de uso productivo.
IF NOT EXISTS (
    SELECT 1
    FROM dbo.Usuarios
    WHERE NombreUsuario = N'admin'
)
INSERT INTO dbo.Usuarios (IdRol, NombreCompleto, NombreUsuario, ContrasenaHash, Activo)
SELECT IdRol,
       N'Administrador inicial',
       N'admin',
       N'PBKDF2-SHA256$100000$ZqScFdz+yqjKxuVwgPJlEA==$NR/sJeFOs5hvHw+ZJ+qokeBoloyJdifUwimupO5C6Xc=',
       1
FROM dbo.Roles
WHERE Nombre = N'Administrador';
GO

-- Comprobacion: deben aparecer las seis tablas del modelo.
SELECT name AS Tabla
FROM sys.tables
WHERE schema_id = SCHEMA_ID(N'dbo')
ORDER BY name;
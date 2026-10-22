using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Transactions;
using ProyectoVentasTel.Aplicacion.Seguridad;
using ProyectoVentasTel.Aplicacion.Servicios;
using ProyectoVentasTel.Dominio.Productos;
using ProyectoVentasTel.Dominio.Seguridad;
using ProyectoVentasTel.Infraestructura.Datos;
using ProyectoVentasTel.Infraestructura.Imagenes;

class PruebasProductos
{
    static int comprobaciones;
    static void Afirmar(bool valor, string caso) { if (!valor) throw new Exception(caso); comprobaciones++; }
    static void Rechaza<T>(Action accion) where T : Exception
    {
        try { accion(); } catch (T) { comprobaciones++; return; }
        throw new Exception("Se esperaba " + typeof(T).Name);
    }
    static void Sesion(RolUsuario rol) { SesionActual.Iniciar(new UsuarioAutenticado { IdUsuario = 1, Rol = rol }); }
    static SolicitudNuevoProducto Nuevo(string codigo)
    {
        return new SolicitudNuevoProducto { Codigo = codigo, Nombre = "Producto de prueba", Tipo = TipoProducto.Accesorio, PrecioVenta = 10.25m, Activo = true };
    }
    static SolicitudEdicionProducto Editar(Producto p)
    {
        return new SolicitudEdicionProducto { IdProducto = p.IdProducto, Codigo = p.Codigo, Nombre = p.Nombre,
            Tipo = p.Tipo, Marca = p.Marca, Modelo = p.Modelo, CapacidadGB = p.CapacidadGB,
            Color = p.Color, PrecioVenta = p.PrecioVenta, Activo = p.Activo };
    }
    [STAThread]
    static int Main(string[] args)
    {
        try
        {
            if (args.Length > 0 && args[0] == "--vista")
            {
                Sesion(RolUsuario.Administrador);
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.Run(new ProyectoVentasTel.FrmPrincipal(SesionActual.Usuario));
                return 0;
            }
            ProbarReglasYPermisos();
            ProbarRutasProyecto();
            ProbarImagenes();
            if (Array.IndexOf(args, "--sql") >= 0) ProbarSql();
            Console.WriteLine("Correcto: " + comprobaciones + " comprobaciones.");
            return 0;
        }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
        finally { SesionActual.Cerrar(); }
    }
    static void ProbarReglasYPermisos()
    {
        var repo = new RepositorioFalso(); var almacen = new AlmacenFalso();
        var servicio = new ServicioProductos(repo, almacen);
        SesionActual.Cerrar();
        Rechaza<UnauthorizedAccessException>(() => servicio.ConsultarProductos(null));
        Rechaza<UnauthorizedAccessException>(() => servicio.CrearProducto(Nuevo("A")));
        Sesion(RolUsuario.Vendedor);
        servicio.ConsultarProductos(null);
        Afirmar(!ServicioProductos.PuedeAdministrar(), "Vendedor solo consulta");
        Rechaza<UnauthorizedAccessException>(() => servicio.CrearProducto(Nuevo("A")));
        Rechaza<UnauthorizedAccessException>(() => servicio.ActualizarProducto(new SolicitudEdicionProducto()));
        Sesion(RolUsuario.Inventarios);
        servicio.CrearProducto(Nuevo("A"));
        Afirmar(repo.Creados == 1, "Inventarios crea");
        Sesion(RolUsuario.Administrador);
        var s = Nuevo("  A  "); s.CapacidadGB = 32; s.Marca = "  ";
        var datos = ServicioProductos.ValidarDatos(s);
        Afirmar(datos.Codigo == "A" && datos.CapacidadGB == null && datos.Marca == null, "Normalizar accesorio");
        s.Codigo = " "; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Codigo = new string('x',31);
        Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Codigo = "A";
        s.Nombre = ""; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Nombre = new string('x',101);
        Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Nombre = "Nombre";
        foreach (var precio in new[] { 0m, -1m, 10000000000m, 1.001m })
        { s.PrecioVenta = precio; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); }
        s.PrecioVenta = 9999999999.99m; ServicioProductos.ValidarDatos(s); comprobaciones++;
        s.Tipo = (TipoProducto)99; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s));
        s.Tipo = TipoProducto.Telefono; s.CapacidadGB = null;
        Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s));
        s.CapacidadGB = 128; s.Marca = "M"; s.Modelo = "Modelo"; s.Color = "Negro";
        ServicioProductos.ValidarDatos(s); comprobaciones++;
        s.Marca = " "; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Marca = new string('x',51);
        Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Marca = "M";
        s.Modelo = null; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Modelo = new string('x',81);
        Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Modelo = "Modelo";
        s.Color = " "; Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s)); s.Color = new string('x',31);
        Rechaza<ArgumentException>(() => ServicioProductos.ValidarDatos(s));
        var filtro = new FiltroProductos { Texto = "  " + new string('x',120) + "  ", Tipo = TipoProducto.Telefono, Activo = false };
        servicio.ConsultarProductos(filtro);
        Afirmar(repo.Filtro.Texto.Length == 100 && repo.Filtro.Tipo == TipoProducto.Telefono && repo.Filtro.Activo == false, "Normalizar filtros");
        Rechaza<ArgumentException>(() => servicio.ConsultarProductos(new FiltroProductos { Tipo = (TipoProducto)99 }));
        Rechaza<ProductoNoEncontradoException>(() => servicio.ObtenerProducto(10));
        repo.Duplicado = true;
        Rechaza<ProductoDuplicadoException>(() => servicio.CrearProducto(Nuevo("A"))); repo.Duplicado = false;
        var conImagen = Nuevo("B"); conImagen.ArchivoImagenNuevo = "imagen.png"; repo.Fallar = true;
        Rechaza<InvalidOperationException>(() => servicio.CrearProducto(conImagen));
        Afirmar(almacen.Copias == 1 && almacen.Eliminadas == 1, "Limpiar copia tras fallo SQL");
        repo.Fallar = false; repo.Producto = new Producto { IdProducto = 1, Codigo = "B", Nombre = "B", Tipo = TipoProducto.Accesorio, PrecioVenta = 5, RutaImagen = "anterior.png", Existencias = 17 };
        servicio.ActualizarProducto(Editar(repo.Producto));
        Afirmar(repo.Ruta == "anterior.png", "Conservar imagen existente");
        var edicion = Editar(repo.Producto); edicion.QuitarImagen = true;
        servicio.ActualizarProducto(edicion); Afirmar(repo.Ruta == null, "Quitar imagen");
        edicion.ArchivoImagenNuevo = "nueva.png"; repo.Fallar = true;
        Rechaza<InvalidOperationException>(() => servicio.ActualizarProducto(edicion));
        Afirmar(almacen.Copias == 2 && almacen.Eliminadas == 2, "Limpiar reemplazo fallido");
        Afirmar(typeof(SolicitudNuevoProducto).GetProperty("Existencias") == null && typeof(SolicitudEdicionProducto).GetProperty("Existencias") == null, "Escrituras sin stock");
    }
    static void ProbarImagenes()
    {
        string carpeta = Path.Combine(Path.GetTempPath(), "VISOR-Pruebas-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(carpeta);
        var almacen = new AlmacenImagenesProductos(); var copias = new List<string>();
        string directorioAnterior = Environment.CurrentDirectory;
        string carpetaEsperada = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "img", "productos"));
        try
        {
            Environment.CurrentDirectory = carpeta;
            foreach (string extension in new[] { ".png", ".jpg" })
            {
                string origen = Path.Combine(carpeta, "imagen" + extension);
                using (var bitmap = new Bitmap(8,8)) bitmap.Save(origen, extension == ".png" ? ImageFormat.Png : ImageFormat.Jpeg);
                using (var imagen = AlmacenImagenesProductos.Cargar(origen))
                {
                    File.Delete(origen);
                    Afirmar(imagen.Width == 8, "Imagen decodificada y archivo liberado");
                    imagen.Save(origen, ImageFormat.Png);
                }
                string copia = almacen.Copiar(origen); copias.Add(copia);
                Afirmar(File.Exists(copia) && copia != origen, "Copia administrada");
                Afirmar(Path.IsPathRooted(copia) && Path.GetDirectoryName(copia) == carpetaEsperada, "Guardar en el proyecto aunque cambie el directorio de trabajo");
                using (var imagen = AlmacenImagenesProductos.Cargar(copia)) Afirmar(imagen.Width == 8, "Copia legible");
            }
            string corrupta = Path.Combine(carpeta, "corrupta.png"); File.WriteAllText(corrupta,"no es imagen");
            Rechaza<ArgumentException>(() => AlmacenImagenesProductos.Cargar(corrupta));
            Afirmar(AlmacenImagenesProductos.IntentarCargar(corrupta) == null, "Vista corrupta sin imagen");
            Afirmar(AlmacenImagenesProductos.IntentarCargar(Path.Combine(carpeta,"ausente.png")) == null, "Vista ausente sin imagen");
            Rechaza<ArgumentException>(() => AlmacenImagenesProductos.Cargar("archivo.gif"));
            var repo = new RepositorioFalso();
            var solicitud = Nuevo("IMAGEN"); solicitud.ArchivoImagenNuevo = Path.Combine(carpeta, "imagen.png");
            Sesion(RolUsuario.Administrador);
            Rechaza<AlmacenamientoImagenException>(() => new ServicioProductos(repo, new AlmacenSinPermiso()).CrearProducto(solicitud));
            Afirmar(repo.Creados == 0, "No persistir ante falta de permisos de almacenamiento");
            repo.Fallar = true;
            var registrado = new AlmacenRegistrado();
            try
            {
                Rechaza<InvalidOperationException>(() => new ServicioProductos(repo, registrado).CrearProducto(solicitud));
                Afirmar(registrado.Ruta != null && !File.Exists(registrado.Ruta), "Eliminar copia real del proyecto tras fallo de persistencia");
            }
            finally { if (registrado.Ruta != null) almacen.EliminarCopia(registrado.Ruta); }
        }
        finally
        {
            Environment.CurrentDirectory = directorioAnterior;
            foreach (string copia in copias) almacen.EliminarCopia(copia);
            Directory.Delete(carpeta,true);
        }
    }
    static object InvocarAlmacen(string metodo, params object[] argumentos)
    {
        try { return typeof(AlmacenImagenesProductos).GetMethod(metodo, BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, argumentos); }
        catch (TargetInvocationException ex) { throw ex.InnerException; }
    }
    static void ProbarRutasProyecto()
    {
        string carpeta = Path.Combine(Path.GetTempPath(), "VISOR-Rutas-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(carpeta);
        try
        {
            Rechaza<AlmacenamientoImagenException>(() => InvocarAlmacen("ResolverCarpeta", carpeta));
            File.WriteAllText(Path.Combine(carpeta, "ProyectoVentasTel.vbproj"), "proyecto de prueba");
            string esperado = Path.Combine(carpeta, "img", "productos");
            foreach (string configuracion in new[] { "Debug", "Release" })
            {
                string salida = Path.Combine(carpeta, "bin", configuracion); Directory.CreateDirectory(salida);
                Afirmar((string)InvocarAlmacen("ResolverCarpeta", salida) == esperado, "Misma carpeta desde " + configuracion);
            }
            Afirmar(!Directory.Exists(esperado), "La resolución no necesita que exista la carpeta de imágenes");
            using (var imagen = new Bitmap(8,8))
            {
                string copia = (string)InvocarAlmacen("GuardarImagen", imagen, esperado);
                Afirmar(File.Exists(copia), "Crear carpeta de imágenes inexistente");
                string bloqueo = Path.Combine(carpeta, "archivo-en-lugar-de-carpeta"); File.WriteAllText(bloqueo, "bloqueo");
                Rechaza<AlmacenamientoImagenException>(() => InvocarAlmacen("GuardarImagen", imagen, bloqueo));
            }
        }
        finally { Directory.Delete(carpeta,true); }
    }
    static void ProbarSql()
    {
        Sesion(RolUsuario.Administrador);
        var servicio = new ServicioProductos(); var repo = new RepositorioProductosSqlServer();
        string prefijo = "PR" + Guid.NewGuid().ToString("N").Substring(0,16);
        // Todas las conexiones se incorporan a la misma transacción; nunca se confirma.
        using (var transaccion = new TransactionScope())
        {
            var s = Nuevo(prefijo + "A"); s.Nombre = prefijo + " Nombre"; s.Marca = prefijo + " Marca"; s.Modelo = prefijo + " Modelo";
            int id = servicio.CrearProducto(s); var producto = servicio.ObtenerProducto(id);
            Afirmar(producto.Existencias == 0 && producto.CapacidadGB == null && producto.Activo, "Alta SQL sin existencias");
            foreach (string texto in new[] { s.Codigo, s.Nombre, s.Marca, s.Modelo })
                Afirmar(servicio.ConsultarProductos(new FiltroProductos { Texto = texto, Tipo = TipoProducto.Accesorio, Activo = true }).Count == 1, "Búsqueda combinada SQL");
            Afirmar(servicio.ConsultarProductos(new FiltroProductos { Texto = prefijo, Tipo = TipoProducto.Telefono }).Count == 0, "Filtro sin resultados");
            Rechaza<ProductoDuplicadoException>(() => servicio.CrearProducto(s));
            Rechaza<ProductoDuplicadoException>(() => repo.Crear(ServicioProductos.ValidarDatos(s),null));
            using (var conexion = ConexionSqlServer.Crear())
            using (var comando = new SqlCommand("UPDATE dbo.Productos SET Existencias=7 WHERE IdProducto=@Id",conexion))
            { comando.Parameters.AddWithValue("@Id", id); conexion.Open(); comando.ExecuteNonQuery(); }
            var edicion = Editar(producto); edicion.Nombre = "Actualizado " + prefijo; edicion.Activo = false; edicion.PrecioVenta = 9999999999.99m;
            servicio.ActualizarProducto(edicion); producto = servicio.ObtenerProducto(id);
            Afirmar(producto.Existencias == 7 && !producto.Activo && producto.PrecioVenta == edicion.PrecioVenta, "Edición SQL conserva stock");
            Afirmar(servicio.ConsultarProductos(new FiltroProductos { Texto = prefijo, Activo = false }).Count == 1, "Filtro inactivos");
            Rechaza<ProductoDuplicadoException>(() => servicio.CrearProducto(s));
            var telefono = Nuevo(prefijo + "T"); telefono.Tipo = TipoProducto.Telefono; telefono.Marca = prefijo; telefono.Modelo = "Modelo"; telefono.Color = "Negro"; telefono.CapacidadGB = 128;
            int idTelefono = servicio.CrearProducto(telefono); telefono.Codigo = prefijo + "X";
            Rechaza<ProductoDuplicadoException>(() => servicio.CrearProducto(telefono));
            var cambio = Editar(servicio.ObtenerProducto(idTelefono)); cambio.Activo = false; servicio.ActualizarProducto(cambio);
            Rechaza<ProductoDuplicadoException>(() => repo.Crear(ServicioProductos.ValidarDatos(telefono),null));
            cambio.Tipo = TipoProducto.Accesorio; servicio.ActualizarProducto(cambio);
            Afirmar(servicio.ObtenerProducto(idTelefono).CapacidadGB == null, "Cambio teléfono a accesorio");
            cambio.Tipo = TipoProducto.Telefono; cambio.CapacidadGB = 256; servicio.ActualizarProducto(cambio);
            Afirmar(servicio.ObtenerProducto(idTelefono).CapacidadGB == 256, "Cambio accesorio a teléfono");
            var literal = Nuevo(prefijo + "%_["); servicio.CrearProducto(literal);
            Afirmar(servicio.ConsultarProductos(new FiltroProductos { Texto = prefijo + "%_[" }).Count == 1, "Búsqueda literal de comodines");
            Rechaza<ProductoNoEncontradoException>(() => repo.Actualizar(int.MaxValue, ServicioProductos.ValidarDatos(s), null));
        }
        Afirmar(servicio.ConsultarProductos(new FiltroProductos { Texto = prefijo }).Count == 0, "Transacción revertida");
    }
    class AlmacenSinPermiso : IAlmacenImagenesProductos
    {
        public string Copiar(string archivo) { throw new AlmacenamientoImagenException("No se pudo guardar la imagen en img/productos del proyecto. Comprueba los permisos de escritura."); }
        public void EliminarCopia(string ruta) { throw new Exception("No debe haber una copia que eliminar"); }
    }
    class AlmacenRegistrado : IAlmacenImagenesProductos
    {
        readonly AlmacenImagenesProductos almacen = new AlmacenImagenesProductos();
        public string Ruta;
        public string Copiar(string archivo) { Ruta = almacen.Copiar(archivo); return Ruta; }
        public void EliminarCopia(string ruta) { almacen.EliminarCopia(ruta); }
    }
    class AlmacenFalso : IAlmacenImagenesProductos
    {
        public int Copias, Eliminadas;
        public string Copiar(string archivo) { Copias++; return "copia.png"; }
        public void EliminarCopia(string ruta) { Eliminadas++; }
    }
    class RepositorioFalso : IRepositorioProductos
    {
        public int Creados; public bool Fallar, Duplicado; public Producto Producto; public string Ruta; public FiltroProductos Filtro;
        public IReadOnlyList<Producto> Consultar(FiltroProductos filtro) { Filtro = filtro; return new List<Producto>(); }
        public Producto ObtenerPorId(int id) { return Producto; }
        public bool HayDuplicado(DatosProducto datos, int idExcluido) { return Duplicado; }
        public int Crear(DatosProducto datos, string ruta) { if (Fallar) throw new InvalidOperationException(); Creados++; return Creados; }
        public void Actualizar(int id, DatosProducto datos, string ruta) { if (Fallar) throw new InvalidOperationException(); Ruta = ruta; }
    }
}

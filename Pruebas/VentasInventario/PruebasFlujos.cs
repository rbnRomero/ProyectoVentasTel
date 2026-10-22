using System;
using System.Collections.Generic;
using ProyectoVentasTel.Aplicacion.Seguridad;
using ProyectoVentasTel.Aplicacion.Servicios;
using ProyectoVentasTel.Dominio.Inventario;
using ProyectoVentasTel.Dominio.Seguridad;
using ProyectoVentasTel.Dominio.Ventas;

static class PruebasFlujos
{
    static int casos;

    static void Afirmar(bool valor, string nombre)
    {
        if (!valor) throw new Exception("Falló: " + nombre);
        casos++;
    }

    static void Esperar<T>(Action accion, string nombre) where T : Exception
    {
        try { accion(); }
        catch (T) { casos++; return; }
        throw new Exception("Se esperaba " + typeof(T).Name + ": " + nombre);
    }

    static UsuarioAutenticado Usuario(int id, RolUsuario rol) { return new UsuarioAutenticado { IdUsuario = id, Rol = rol, NombreCompleto = "Prueba" }; }

    static void Main()
    {
        var repoVentas = new RepositorioVentasPrueba();
        var ventas = new ServicioVentas(repoVentas);
        SesionActual.Iniciar(Usuario(7, RolUsuario.Vendedor));
        Esperar<ArgumentException>(() => ventas.Registrar(new List<ArticuloVenta>(), 0), "carrito vacío");
        Esperar<ArgumentException>(() => ventas.Registrar(new[] { Articulo(1, 2, 10m) }, 19.99m), "efectivo insuficiente");
        var folio = ventas.Registrar(new[] { Articulo(1, 1, 10m), Articulo(1, 2, 10m) }, 35m);
        Afirmar(folio == "V-0000000042" && repoVentas.IdVendedor == 7, "registro con vendedor y folio");
        Afirmar(repoVentas.Articulos.Count == 1 && repoVentas.Articulos[0].Cantidad == 3, "consolidación de líneas repetidas");
        ventas.Cancelar(42, "captura duplicada");
        Afirmar(repoVentas.SoloPropias && repoVentas.UsuarioCancela == 7, "Vendedor soloPropias");
        SesionActual.Iniciar(Usuario(1, RolUsuario.Administrador));
        ventas.Cancelar(42, "autorizada");
        Afirmar(!repoVentas.SoloPropias && repoVentas.UsuarioCancela == 1, "Administrador puede cancelar cualquiera");
        SesionActual.Iniciar(Usuario(8, RolUsuario.Vendedor));
        Esperar<ArgumentException>(() => ventas.Consultar(new FiltroVentas { Desde = DateTime.Today, Hasta = DateTime.Today.AddDays(-1) }), "rango de fechas invertido");

        var repoEntradas = new RepositorioEntradasPrueba();
        var entradas = new ServicioEntradasInventario(repoEntradas);
        SesionActual.Iniciar(Usuario(9, RolUsuario.Inventarios));
        Esperar<ArgumentException>(() => entradas.Registrar(1, 0, ""), "entrada cero");
        entradas.Registrar(4, 15, "recepción de proveedor");
        Afirmar(repoEntradas.IdProducto == 4 && repoEntradas.IdUsuario == 9 && repoEntradas.Cantidad == 15, "entrada con usuario y cantidad");
        SesionActual.Iniciar(Usuario(7, RolUsuario.Vendedor));
        Esperar<UnauthorizedAccessException>(() => entradas.Consultar(), "Vendedor sin acceso a inventario");
        SesionActual.Cerrar();
        Esperar<UnauthorizedAccessException>(() => ventas.BuscarProductos(""), "sesión cerrada sin acceso");
        Console.WriteLine("Correcto: " + casos + " comprobaciones de servicios de ventas e inventario.");
    }

    static ArticuloVenta Articulo(int id, int cantidad, decimal precio) { return new ArticuloVenta { IdProducto = id, Codigo = "P-1", Nombre = "Producto", Cantidad = cantidad, PrecioUnitario = precio }; }

    sealed class RepositorioVentasPrueba : IRepositorioVentas
    {
        public IReadOnlyList<ArticuloVenta> Articulos;
        public int IdVendedor;
        public int UsuarioCancela;
        public bool SoloPropias;
        public IReadOnlyList<ProductoParaVenta> BuscarProductos(string texto) { return new List<ProductoParaVenta>(); }
        public string Registrar(int idVendedor, IReadOnlyList<ArticuloVenta> articulos, decimal efectivo)
        { IdVendedor = idVendedor; Articulos = articulos; return "V-0000000042"; }
        public IReadOnlyList<VentaListado> Consultar(FiltroVentas filtro) { return new List<VentaListado>(); }
        public VentaDetalle Obtener(int idVenta) { return null; }
        public void Cancelar(int idVenta, int idUsuarioCancela, string motivo, bool soloPropias)
        { UsuarioCancela = idUsuarioCancela; SoloPropias = soloPropias; }
    }

    sealed class RepositorioEntradasPrueba : IRepositorioEntradasInventario
    {
        public int IdProducto, IdUsuario, Cantidad;
        public IReadOnlyList<ProductoEntrada> ProductosActivos() { return new List<ProductoEntrada>(); }
        public IReadOnlyList<EntradaInventario> Consultar() { return new List<EntradaInventario>(); }
        public int Registrar(int idProducto, int idUsuario, int cantidad, string observaciones)
        { IdProducto = idProducto; IdUsuario = idUsuario; Cantidad = cantidad; return 1; }
    }
}

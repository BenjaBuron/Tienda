namespace Tienda.Modelos;
class program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Benjamin", 3364328944, "A15RT");
        
        Producto producto1 = new Producto("Moladora", 35000,"Stanley150");
        
        Venta venta = new Venta(DateTime.Now,3,cliente);
        cliente.MostrarCliente();
        venta.MostrarVenta();
        producto1.MostrarDetalles();
        venta.CalcularTotal();
    }
}
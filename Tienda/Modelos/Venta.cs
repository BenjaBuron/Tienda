namespace Tienda.Modelos
{
    public class Venta
    {
        public DateTime Fecha {  get;private set; }

        public Producto ProductoVendido { get;private set; }
        public int Cantidad { get;private set; }
        public Cliente Cliente { get;private set; }


         public Venta(DateTime fecha,  int cantidad, Cliente cliente )
         {
            Fecha = fecha;
            Cantidad = cantidad;
            Cliente = cliente;
         }
         public void CalcularTotal()
        {
            Console.WriteLine($"El total a pagar es de {Cantidad}");// se que la consigna dice que el metodo es double pero no me sale
        }
        public void MostrarVenta()
        {
            Console.WriteLine($"Venta\nFECHA :{Fecha}\nCantidad: {Cantidad}");
        }

    }
}

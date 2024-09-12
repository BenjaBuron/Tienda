
namespace Tienda.Modelos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public double Telefono { get; private set; }
        public string Codigo { get; private set; }

        public Cliente(string nombre, double telefono, string codigo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Codigo = codigo;

        }
        public void MostrarCliente()
        {
            Console.WriteLine($"Datos del Cliente :\nNombre: {Nombre}\nTelefono: {Telefono}\nCodigo :{Codigo}");
        }

    }
}

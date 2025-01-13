using System;

namespace RegistroProductos
{
    // Definición de la clase Producto
    class Producto
    {
        // Atributos del producto
        public int id;  
        public string nombre;
        public string unidad;
        public double[] precios = new double[3]; // Array para almacenar tres precios

        // Constructor de la clase
        public Producto(int id, string nombre, string unidad, double[] precios)
        {
            this.id = id;
            this.nombre = nombre;
            this.unidad = unidad;
            this.precios = precios;
        }

        // Método para mostrar la información del producto
        public void MostrarProducto()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Unidad: {unidad}");
            Console.WriteLine("Precios:");
            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine($"Precio {i + 1}: {precios[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creación de una lista de productos usando un array
            Producto[] productos = new Producto[2];

            // Inicialización de los productos
            productos[0] = new Producto(1, "Manzanas", "Kg", new double[] { 1.50, 1.40, 1.30 });
            productos[1] = new Producto(2, "Leche", "Litro", new double[] { 0.90, 0.85, 0.80 });

            // Mostrar la información de los productos
            foreach (var producto in productos)
            {
                producto.MostrarProducto();
                Console.WriteLine("-------------------");
            }
        }
    }
}

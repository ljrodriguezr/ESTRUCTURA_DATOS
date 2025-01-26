using System;
using System.Collections.Generic;
using System.Linq;
public static class manejodelistas{
    public static void Run() {
        {
            List<double> listaPrincipal = new List<double>();
            List<double> listaMenoresIgualPromedio = new List<double>();
            List<double> listaMayoresPromedio = new List<double>();

            Console.Write("¿Cuántos datos deseas ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());
            // Cargar datos en la lista principal
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Introduce el dato #{i + 1}: ");
                double dato = double.Parse(Console.ReadLine());
                listaPrincipal.Add(dato);
            }

            // Calcular el promedio
            double promedio = listaPrincipal.Average();

            // Clasificar los datos en las listas correspondientes
            foreach (double dato in listaPrincipal)
            {
                if (dato <= promedio)
                {
                    listaMenoresIgualPromedio.Add(dato);
                }
                else
                {
                    listaMayoresPromedio.Add(dato);
                }
            }

            // Mostrar resultados
            Console.WriteLine("\n--- Resultados ---");

            Console.WriteLine("a. Datos cargados en la lista principal:");
            foreach (double dato in listaPrincipal)
            {
                Console.WriteLine(dato);
            }

            Console.WriteLine($"\nb. El promedio es: {promedio:F2}");

            Console.WriteLine("\nc. Datos menores o iguales al promedio:");
            foreach (double dato in listaMenoresIgualPromedio)
            {
                Console.WriteLine(dato);
            }

            Console.WriteLine("\nd. Datos mayores al promedio:");
            foreach (double dato in listaMayoresPromedio)
            {
                Console.WriteLine(dato);
 }
        }
    }
}

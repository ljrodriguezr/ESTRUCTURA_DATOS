using System;
using System.Collections.Generic;
public static class ejercicio4
{

    public static void Run()
    {
        //Pegar aqui el codigo
        {
            // Crear una lista de precios
            List<int> precios = new List<int> { 40, 75, 56, 12, 90, 75, 1 };

            // Encontrar el precio mayor y menor
            int precioMayor = precios[0];
            int precioMenor = precios[0];

            foreach (int precio in precios)
            {
                if (precio > precioMayor)
                {
                    precioMayor = precio;
                }
                if (precio < precioMenor)
                {
                    precioMenor = precio;
                }
            }

            // Mostrar los resultados
            Console.WriteLine($"El precio mayor es: {precioMayor}");
            Console.WriteLine($"El precio menor es: {precioMenor}");

        }
    }
}
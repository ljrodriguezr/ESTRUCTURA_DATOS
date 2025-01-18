using System;
using System.Collections.Generic;
public static class ejercicio3
{
    public static void Run()
    {
        //Pegar aqui el codigo

        // Crear una lista para almacenar los números del 1 al 10
        List<int> numeros = new List<int>();

        // Llenar la lista con los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Mostrar los números en orden inverso
        Console.WriteLine("Números del 1 al 10 en orden inverso:");
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            // Imprimir el número y, si no es el primero, agregar una coma
            if (i < numeros.Count - 1)
            {
                Console.Write(", ");
            }
            Console.Write(numeros[i]);
        }

        // Salto de línea al final
        Console.WriteLine();
    }
}
    

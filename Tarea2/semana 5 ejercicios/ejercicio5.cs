using System;
using System.Collections.Generic;
public static class ejercicio5{

    public static void Run() {
        //Pegar aqui el codigo
        {
            // Crear una lista con las letras del abecedario
            List<char> abecedario = new List<char>();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                abecedario.Add(letra);
            }

            // Eliminar las letras en posiciones múltiplos de 4
            for (int i = abecedario.Count - 1; i >= 0; i--)
            {
                if ((i + 1) % 4 == 0)  // Las posiciones son base 1
                {
                    abecedario.RemoveAt(i);
                }
            }

            // Mostrar la lista resultante
            Console.WriteLine("El abecedario después de eliminar las letras en posiciones múltiplos de 4 es:");
            foreach (var letra in abecedario)
            {
                Console.Write(letra + " ");
            }

        }
    }
}
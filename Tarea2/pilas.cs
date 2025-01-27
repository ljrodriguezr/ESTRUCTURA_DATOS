using System;
    using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Ejemplo de fórmula a verificar
        string formula = "{7+(8*5)-[(9-7)+(4+1)]}";

        // Llamar a la función de verificación
        if (IsBalanced(formula))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula no balanceada.");
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.ReadKey();
    }

    static bool IsBalanced(string formula)
    {
        // Diccionario para pares de símbolos
        Dictionary<char, char> pairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        // Pila para almacenar los símbolos de apertura
        Stack<char> stack = new Stack<char>();

        foreach (char c in formula)
        {
            // Si es un símbolo de apertura, lo agregamos a la pila
            if (pairs.ContainsValue(c))
            {
                stack.Push(c);
            }
            // Si es un símbolo de cierre, verificamos
            else if (pairs.ContainsKey(c))
            {
                // Si la pila está vacía o el símbolo no coincide, no está balanceado
                if (stack.Count == 0 || stack.Pop() != pairs[c])
                {
                    return false;
                }
            }
        }

        // Al final, la pila debe estar vacía si la fórmula está balanceada
        return stack.Count == 0;
    }
}
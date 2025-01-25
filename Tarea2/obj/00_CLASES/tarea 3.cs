using System;
using System.Collections.Generic;

//Implementar el método de búsqueda en la clase lista, el cual debe retornar el número de cual debe retornar el número de
//veces que se encuentra el dato dentro veces que se encuentra el dato dentro de la lista. de la lista. En caso de no encontrarse, el método d En caso de no encontrarse, el método debe
//mostrar un mensaje indicando que el dato mostrar un mensaje indicando que el dato no fue enc no fue encontrado. El parámetro de entrada del ontrado. El parámetro de entrada del
//método es el valor que método es el valor que se desea buscar. se desea buscar.

public class Lista
{
    private List<int> elementos; // Lista genérica para almacenar los elementos

    // Constructor para inicializar la lista
    public Lista()
    {
        elementos = new List<int>();
    }

    // Método para agregar elementos a la lista
    public void AgregarElemento(int elemento)
    {
        elementos.Add(elemento); // Agrega el elemento a la lista
    }

    // Método para buscar cuántas veces aparece un dato en la lista
    public int BuscarDato(int dato)
    {
        int contador = 0; // Contador para registrar las ocurrencias del dato

        // Recorre la lista y cuenta las veces que aparece el dato
        foreach (int elemento in elementos)
        {
            if (elemento == dato)
            {
                contador++; // Incrementa el contador si el dato coincide
            }
        }

        // Verifica si el dato fue encontrado o no
        if (contador > 0)
        {
            Console.WriteLine($"El dato {dato} se encontró {contador} veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El dato {dato} no fue encontrado en la lista.");
        }

        return contador; // Retorna el número de ocurrencias
    }

    // Método para mostrar todos los elementos de la lista
    public void MostrarElementos()
    {
        Console.WriteLine("Elementos de la lista: " + string.Join(", ", elementos)); // Muestra los elementos separados por comas
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una nueva instancia de la clase Lista
        Lista miLista = new Lista();

        // Agregar elementos a la lista
        miLista.AgregarElemento(1);
        miLista.AgregarElemento(2);
        miLista.AgregarElemento(3);
        miLista.AgregarElemento(2);
        miLista.AgregarElemento(5);

        // Mostrar todos los elementos de la lista
        miLista.MostrarElementos();

        // Buscar un dato que está en la lista
        miLista.BuscarDato(2); // Dato presente en la lista

        // Buscar un dato que no está en la lista
        miLista.BuscarDato(4); // Dato ausente en la lista
    }
}
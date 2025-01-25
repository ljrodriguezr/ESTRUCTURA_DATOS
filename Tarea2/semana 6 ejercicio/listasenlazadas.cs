using System;
using System.Collections.Generic;

public static class ListasEnlazadas
{
    public static void Run()
    {
        // Crear una nueva instancia de la clase Lista
        Lista miLista = new Lista();

        // Agregar elementos a la lista
        miLista.AgregarElemento(8);
        miLista.AgregarElemento(5);
        miLista.AgregarElemento(3);
        miLista.AgregarElemento(2);
        miLista.AgregarElemento(5);

        // Mostrar todos los elementos de la lista
        miLista.MostrarElementos();

        // Buscar un dato que está en la lista
        miLista.BuscarDato(5); // Dato presente en la lista

        // Buscar un dato que no está en la lista
        miLista.BuscarDato(4); // Dato ausente en la lista
    }
}

public class Lista
{
    private List<int> elementos;

    // Constructor
    public Lista()
    {
        elementos = new List<int>();
    }

    public void AgregarElemento(int elemento)
    {
        elementos.Add(elemento);
    }

    public int BuscarDato(int dato)
    {
        int contador = 0;
        foreach (int elemento in elementos)
        {
            if (elemento == dato)
            {
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.WriteLine($"El dato {dato} se encontró {contador} veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El dato {dato} no fue encontrado en la lista.");
        }

        return contador;
    }

    public void MostrarElementos()
    {
        if (elementos.Count > 0)
        {
            Console.WriteLine("Elementos de la lista: " + string.Join(", ", elementos));
        }
        else
        {
            Console.WriteLine("La lista está vacía.");
        }
    }
}

// Asegúrate de que la clase Program tenga el modificador parcial si hay múltiples definiciones
public partial class Program
{
    static void Main(string[] args)
    {
        ListasEnlazadas.Run();
    }
}
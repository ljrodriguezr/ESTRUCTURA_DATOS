public static class ejercicio2
{
    public static void Run()
    {
        //Pegar aqui el codigo
         Console.WriteLine("ejercicio 2");
         Console.WriteLine("==============");

        // Lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Diccionario para almacenar las notas
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Solicitar al usuario las notas para cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Introduce la nota de {asignatura}: ");
            double nota;
            // Validar la entrada del usuario
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.Write("Por favor, introduce una nota válida (0-10): ");
            }
            notas[asignatura] = nota;
        }

        // Eliminar asignaturas aprobadas (considerando 5 como la nota mínima para aprobar)
        foreach (var asignatura in new List<string>(asignaturas)) // Usar una copia de la lista para evitar problemas al eliminar
        {
            if (notas[asignatura] >= 5)
            {
                asignaturas.Remove(asignatura);
            }
        }

        // Mostrar las asignaturas que el usuario tiene que repetir
        Console.WriteLine("\nAsignaturas que tienes que repetir:");
        if (asignaturas.Count > 0)
        {
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }
        }
        else
        {
            Console.WriteLine("No tienes asignaturas que repetir.");
        }
    }
}
    
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
static void Main()
{
// Generamos conjunto de 500 ciudadanos
HashSet<string> ciudadanos = new HashSet<string>();
for (int i = 1; i <= 500; i++)
{
ciudadanos.Add($"Ciudadano {i}");
}

// Generamos listado de vacunados
HashSet<string> vacunadosPfizer = new HashSet<string>();
HashSet<string> vacunadosAstrazeneca = new HashSet<string>();

Random random = new Random();
List<string> ciudadanosList = ciudadanos.ToList();

// observamos 75 ciudadanos para Pfizer
while (vacunadosPfizer.Count < 75)
{
int index = random.Next(ciudadanosList.Count);
vacunadosPfizer.Add(ciudadanosList[index]);
}

// observamos 75 ciudadanos para Astrazeneca (viendo que no se repitan con Pfizer)
while (vacunadosAstrazeneca.Count < 75)
{
int index = random.Next(ciudadanosList.Count);
if (!vacunadosPfizer.Contains(ciudadanosList[index]))
{
vacunadosAstrazeneca.Add(ciudadanosList[index]);
}
}

// Lista de ciudadanos que no se han vacunado
HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
noVacunados.ExceptWith(vacunadosPfizer);
noVacunados.ExceptWith(vacunadosAstrazeneca);

// Lista de ciudadanos que se han vacunado 2 vacunas (intersección)
HashSet<string> ambasVacunas = new HashSet<string>(vacunadosPfizer);
ambasVacunas.IntersectWith(vacunadosAstrazeneca);

// Lista de ciudadanos que solamente se han vacunado de Pfizer
HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
soloPfizer.ExceptWith(vacunadosAstrazeneca);

// Lista de ciudadanos que solamente se han vacunado de Astrazeneca
HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca);
soloAstrazeneca.ExceptWith(vacunadosPfizer);

// Mostrar resultados
Console.WriteLine("Ciudadanos no vacunados:");
foreach (var ciudadano in noVacunados)
{
Console.WriteLine(ciudadano);
}

Console.WriteLine("\nCiudadanos con ambas vacunas:");
foreach (var ciudadano in ambasVacunas)
{
Console.WriteLine(ciudadano);
}

Console.WriteLine("\nCiudadanos solo vacunados con Pfizer:");
foreach (var ciudadano in soloPfizer)
{
Console.WriteLine(ciudadano);
}

Console.WriteLine("\nCiudadanos solo vacunados con Astrazeneca:");
foreach (var ciudadano in soloAstrazeneca)
{
Console.WriteLine(ciudadano);
}
}
}









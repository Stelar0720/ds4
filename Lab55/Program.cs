using System;
using System.Collections.Generic; // Necesario para usar List

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de estudiantes
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Edad = 13 },
            new Estudiante { Nombre = "Juan", Edad = 10 },
            new Estudiante { Nombre = "Pedro", Edad = 12 }
        };

        // Iterar sobre la lista y mostrar la información de cada estudiante
        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine("Nombre: " + estudiante.Nombre + ", Edad: " + estudiante.Edad);
        }

        Console.ReadKey(); // Esperar a que el usuario presione una tecla
    }
}




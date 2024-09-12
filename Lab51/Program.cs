using System;

class Program
{
    private int[] sueldos; // Declaramos un vector

    public void Cargar()
    {
        sueldos = new int[5]; // Inicializamos un vector de tamaño 5
        for (int f = 0; f < 5; f++) // Los índices van de 0 a 4
        {
            Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // Asignamos los 5 sueldos al vector 
        }
    }

    // Muestra los sueldos de los operarios en el vector sueldos[f]
    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios:");
        for (int f = 0; f < 5; f++) // Los índices van de 0 a 4
        {
            Console.Write("[" + sueldos[f] + "]");
        }
        Console.ReadKey(); // Correcta llamada a ReadKey
    }

    // Método principal
    static void Main(string[] args)
    {
        Program program = new Program(); // Crear una instancia de Program
        program.Cargar(); // Llamar a Cargar
        program.Imprimir(); // Llamar a Imprimir
    }
}


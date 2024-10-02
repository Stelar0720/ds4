using System;
using lab94;

class Program
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.Write("Ingrese el valor mínimo: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo: ");
        int max = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de números a generar: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] arreglo = aleatorios.GenerarArreglo(min, max, cantidad);

        Console.WriteLine("Números generados:");
        foreach (int num in arreglo)
        {
            Console.WriteLine(num);
        }
    }
}


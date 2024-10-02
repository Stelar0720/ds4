using System;

class Triangulo
{
    static void Main()
    {
        Console.Write("Ingrese el lado 1: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado 2: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado 3: ");
        double lado3 = double.Parse(Console.ReadLine());

        if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo isósceles.");
            }
            else
            {
                Console.WriteLine("Es un triángulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("No es un triángulo válido.");
        }
    }
}


using lab95;
using System;
using System.Collections.Generic;

class ProgramaPrincipal
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

        int[] numerosNoRepetidos = GenerarNumerosNoRepetidos(aleatorios, min, max, cantidad);

        Console.WriteLine("Números aleatorios no repetidos:");
        foreach (int num in numerosNoRepetidos)
        {
            Console.WriteLine(num);
        }
    }

    static int[] GenerarNumerosNoRepetidos(Aleatorios aleatorios, int min, int max, int cantidad)
    {
        HashSet<int> numeros = new HashSet<int>();

        while (numeros.Count < cantidad)
        {
            int numero = aleatorios.GenerarNumero(min, max);
            numeros.Add(numero);
        }

        int[] resultado = new int[numeros.Count];
        numeros.CopyTo(resultado);
        return resultado;
    }
}

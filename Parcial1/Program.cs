using System;

class Program
{
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Ingrese el tamaño de la matriz, debe ser impar: ");
            N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("Recuerde, el numero ingresado debe ser impar\n");
            }

        } while (N % 2 == 0);

        int[,] matriz = new int[N, N];
        Random random = new Random();
        
        int medio = N / 2;

        for (int i = 0; i < N; i++)
        {
            matriz[medio, i] = random.Next(1, 101);
            matriz[i, medio] = random.Next(1, 101);
        }

        Console.Write("\nMatriz creada: \n");
        for (int i = 0;i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sumarfilamedio = 0;
        for (int i = 0; i < N; i++)
        { 
            sumarfilamedio += matriz[medio, i];
        }

        int sumarcolumnamedio = 0;
        for (int i = 0; i < N; i++)
        { 
            sumarcolumnamedio += matriz[i, medio];
        }

        Console.WriteLine($"\nSuma de los valores de la fila medio: {sumarfilamedio}");
        Console.WriteLine($"Suma de los valores de la columna medio: {sumarcolumnamedio}");
    }
}

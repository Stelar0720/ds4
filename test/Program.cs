using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que coloque el tamaño de la matriz (N)
        Console.WriteLine("Ingrese el tamaño de la matriz (Coloca un numero par por favor, representa a (N)): ");

        // Leer el tamaño de la matriz desde la consola y convertirlo a un entero
        int N = int.Parse(Console.ReadLine());

        // Validar que el tamaño ingresado sea un número par
        if (N % 2 != 0)
        {
            Console.WriteLine("El tamaño de la matriz debe ser un número par.");
            return; // Termina el programa si N no es par
        }

        // Crear una matriz bidimensional de tamaño N x N
        int[,] matriz = new int[N, N];

        // Crear un generador de números aleatorios
        Random random = new Random();

        // Variable para almacenar la suma de los valores en la diagonal principal
        int sumaDiagonal = 0;

        // Recorrer las filas de la matriz
        for (int i = 0; i < N; i++)
        {
            // Recorrer las columnas de la matriz
            for (int j = 0; j < N; j++)
            {
                // Si la posición está en la diagonal principal y no es la primera ni la última columna
                if (i == j && j != 0 && j != N - 1)
                {
                    // Asignar un valor aleatorio entre 101 y 200 a la diagonal principal
                    matriz[i, j] = random.Next(101, 201);

                    // Sumar el valor de la diagonal principal a la variable de suma
                    sumaDiagonal += matriz[i, j];
                }
                else
                {
                    // Asignar 0 a las demás posiciones de la matriz
                    matriz[i, j] = 0;
                }
            }
        }

        // Mostrar la matriz generada en formato de tabla
        Console.WriteLine("\nMatriz generada:");

        // Recorrer las filas de la matriz para mostrarla
        for (int i = 0; i < N; i++)
        {
            // Recorrer las columnas de la matriz para mostrar cada valor en la fila actual
            for (int j = 0; j < N; j++)
            {
                // Imprimir el valor de la posición actual, seguido de un tabulador
                Console.Write(matriz[i, j] + "\t");
            }
            // Insertar un salto de línea al finalizar cada fila
            Console.WriteLine();
        }

        // Mostrar la suma total de los valores de la diagonal principal
        Console.WriteLine("\nSuma de los valores de la diagonal principal (excepto la primera y última columna): " + sumaDiagonal);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]); // Aquí se genera una excepción
        }
        catch (IndexOutOfRangeException e) // Específico para el error de índice fuera de rango
        {
            Console.WriteLine("Error: " + e.Message); // Mostrar el mensaje del error
            Console.WriteLine("Algo salió mal, validando el índice del arreglo.");
        }
        catch (Exception e) // Captura cualquier otro tipo de excepción
        {
            Console.WriteLine("Error inesperado: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Continuación de la aplicación, luego del bloque try/catch.");
        }
    }
}


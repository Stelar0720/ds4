using System;

class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Acceso negado - No cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            checkAge(15); // Intenta verificar la edad
        }
        catch (ArithmeticException e) // Captura la excepción específica
        {
            Console.WriteLine("Error: " + e.Message); // Muestra el mensaje de la excepción
        }
        finally
        {
            Console.WriteLine("Proceso finalizado."); // Mensaje final, siempre se ejecuta
        }
    }
}


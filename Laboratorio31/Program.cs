internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Introduce el primer número: ");
        int primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        int segundoNumero = Convert.ToInt32(Console.ReadLine());

        double resultadoOperacion = CalculosMatematicos.Calcular(primerNumero, segundoNumero);
        Console.WriteLine("El resultado de la operación (a+b)*(a-b) es: {0}", resultadoOperacion);
    }
}

internal class CalculosMatematicos
{
    // Método para calcular (a+b)*(a-b)
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }
}


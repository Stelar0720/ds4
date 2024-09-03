internal class Program
{
    private static void Main(String[] args)
    {
        Console.Write("Introduce el radio del circulo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double areaCirculo = CalculosMatematicos.CalculoArea(radio);
        Console.WriteLine("El area del circulo es: {0}", areaCirculo);
    }
}

internal class CalculosMatematicos
{
    public static double CalculoArea(double radio)
    {
        return 3.1416 * Math.Pow(radio, 2);    
    }
}
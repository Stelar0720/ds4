internal class Program
{
    private static void Main(String[] args)
    {

        Console.Write("Introduce el lado largo del rectangulo: ");
        double largo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el lado corto del rectangulo: ");
        double corto = Convert.ToDouble(Console.ReadLine());

        double perimetroRectangulo = 2 * (largo + corto);
        Console.WriteLine("El perimetro del rectangulo es: {0}", perimetroRectangulo);
    }
}

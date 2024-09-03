internal class Program
{
    private static void Main(String[] args)
    {

        Console.Write("Introduce el lado largo del rectangulo: ");
        double ladoLargo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el lado corto del rectangulo: ");
        double ladoCorto = Convert.ToDouble(Console.ReadLine());

        double perimetroRectangulo = 2 * (ladoLargo + ladoCorto);
        Console.WriteLine("El perimetro del rectangulo es: {0}", perimetroRectangulo);
    }
}

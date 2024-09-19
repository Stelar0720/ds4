internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}

public class ClaseBase
// Eliminar la palabra clave sealed de ClaseBase, si deseas que ClaseHijo pueda heredar de ella.
{
    public void test()
    {
    }

    public void moreTesting()
    {
    }
}

class ClaseHijo : ClaseBase
{
}


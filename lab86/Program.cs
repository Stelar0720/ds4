class ClaseBase
{
    public virtual void test()
    {
    }

    public virtual void masTests()
    {
    }
}

class ClaseHijo : ClaseBase
{
    public sealed override void masTests()
    {
        Console.WriteLine("Método masTests sellado en ClaseHijo.");
    }
}

class ClaseNieto : ClaseHijo
{
    // No se puede sobrescribir masTests aquí porque está sellado en ClaseHijo
    // public override void masTests() {} -> Esto daría error
}

internal class Program
{
    private static void Main(string[] args)
    {
        ClaseHijo hijo = new ClaseHijo();
        hijo.masTests();

        Console.WriteLine("Corrió la aplicación");
    }
}


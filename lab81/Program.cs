using lab81;
using System;

public class Program
{
    public static void Main()
    {
        Trabajador p = new Trabajador("Josan", 22, "77588268-Z", 100000);
        Console.WriteLine("Nombre: " + p.Nombre);
        Console.WriteLine("Edad: " + p.Edad);
        Console.WriteLine("NIF: " + p.NIF);
        Console.WriteLine("Sueldo: " + p.Sueldo);
        Console.ReadKey();
    }
}
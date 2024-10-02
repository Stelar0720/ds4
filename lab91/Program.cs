using System;

class Pago
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto (valor positivo): ");
        double precio = double.Parse(Console.ReadLine());

        if (precio <= 0)
        {
            Console.WriteLine("El precio debe ser un valor positivo.");
            return;
        }

        Console.Write("Forma de pago (efectivo/tarjeta): ");
        string formaPago = Console.ReadLine().ToLower();

        if (formaPago == "tarjeta")
        {
            Console.Write("Ingrese su número de tarjeta (16 dígitos): ");
            string numeroTarjeta = Console.ReadLine();

            if (numeroTarjeta.Length == 16 && long.TryParse(numeroTarjeta, out _))
            {
                Console.WriteLine("Pago aceptado con tarjeta.");
            }
            else
            {
                Console.WriteLine("Número de tarjeta inválido.");
            }
        }
        else if (formaPago == "efectivo")
        {
            Console.WriteLine("Pago aceptado en efectivo.");
        }
        else
        {
            Console.WriteLine("Forma de pago no válida.");
        }
    }
}


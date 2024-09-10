using System;
using System.Diagnostics.CodeAnalysis;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 70;
            double num2 = 67.89;
            double num3 = 67.89;
            
            Console.WriteLine(suma(num1,num2));
            Console.WriteLine(suma(num1, num2, num3));
        }

        static double suma(int x, double y, double z = 0)
        { 
        return x+y+z;
        }
    }
}
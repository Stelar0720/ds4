using Microsoft.VisualBasic;
using System;

namespace Laboratio21
{
    public class Program
    {
        public static void Main()
        {
            //asignando valor a variable estatica.
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);        
        }
    }
    public class MyClass
    {
        //declarando variable estatica
        public static int Valor;
    }
}

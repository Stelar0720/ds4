using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab95
{
    class Aleatorios
    {
        private Random random;

        // Constructor
        public Aleatorios()
        {
            random = new Random();
        }

        // i. Generar un número entre dos números
        public int GenerarNumero(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        // ii. Generar un arreglo de números aleatorios entre dos números
        public int[] GenerarArreglo(int min, int max, int cantidad)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }
}

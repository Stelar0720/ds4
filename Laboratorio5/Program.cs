// Declaracion erronea
int valores[];

// Declaracion correcta
int[] valores0;

int[] valores01; // valores sin inicializar
valores01 = new int[100]; // 100 elementos
valores01 = new int[20]; // ahora contiene 20 elementos

// Arreglos unidimensionales o de dimension simple
int[,] valores1; // sin inicializar
int[,] valores2 = new int[3, 7];
int[,,] valores3 = new int[3, 4, 2]; // Arreglo de tres dimensiones

// Arreglo de arreglos
int[][] matriz; // sin inicializar
int[][] matriz2 = new int[3][];
for (int i = 0; i < matriz2.Length; i++)
{
    matriz2[i] = new int[4];
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TRABAJO SUPERVISADO SEMANA 13 RICARDO GUERRA 1234123");
        Console.WriteLine("Ingrese la cantidad de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas: ");
        int columnas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[filas, columnas];

        for (int j = 1; j <= filas; j++)
        {
            for (int i = 1; i <= columnas; i++)
            {
                matriz[j - 1, i - 1] = j * i;
            }
        }

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();

        }
        Console.ReadKey();
    }
}
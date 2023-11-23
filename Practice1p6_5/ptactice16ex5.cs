using System;

class Program
{
    static void Main()
    {
        int n = 3;
        int m = 4;

        int[,] matrix = new int[n, m];

        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(2);
            }
        }

        int[,] newMatrix = new int[n, m + 1];
        for (int i = 0; i < n; i++)
        {
            int countOnes = 0;
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                {
                    countOnes++;
                }
            }
            newMatrix[i, m] = countOnes % 2 == 0 ? 0 : 1;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Новая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
using System;
using System.IO;
using System.Linq;

class practice15ex1
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask1.txt");
        int[] numbers = Array.ConvertAll(lines, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int product = 1;

        for (int i = minIndex + 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        Console.WriteLine("Произведение элементов после минимального: " + product);
        Console.ReadLine();
    }
}
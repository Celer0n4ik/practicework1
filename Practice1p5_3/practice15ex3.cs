using System;
using System.IO;
using System.Linq;

class practice15ex3
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask3.txt");
        string[] numbersStr = lines[0].Split(' ');
        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int sum = 0;
        for (int i = 0; i < minIndex; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / minIndex;
        Console.WriteLine("Среднее арифметическое чисел, расположенных до минимального: " + average);
        Console.ReadLine();
    }
}
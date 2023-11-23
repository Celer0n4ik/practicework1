using System;
using System.IO;
using System.Linq;

class practice15ex4
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask4.txt");
        int[] numbers = Array.ConvertAll(lines, int.Parse);

        int maxNumber = numbers.Max();
        int sum = numbers.Where(x => Math.Abs(x - maxNumber) == 1).Sum();

        Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
        Console.ReadLine();
    }
}
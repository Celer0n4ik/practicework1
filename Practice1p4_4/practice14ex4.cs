using System;
using System.IO;

class practice14ex4
{
    static void Main()
    {
        string[] numbers = File.ReadAllText("numsTask4.txt").Split(' ');
        int count = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                count++;
            }
        }

        Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
        Console.ReadLine();
    }
}
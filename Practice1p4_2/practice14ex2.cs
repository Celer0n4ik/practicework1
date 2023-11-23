using System;
using System.IO;

class practice14ex2
{
    static void Main()
    {
        string[] numbers = File.ReadAllText("numsTask2.txt").Split(';');
        double sum = 0;

        foreach (string number in numbers)
        {
            double n = Convert.ToDouble(number);
            if (n > 0)
            {
                sum += n;
            }
            if (n == 0)
            {
                break;
            }
        }

        Console.WriteLine("Сумма положительных элементов последовательности до 0 равна " + sum);
        Console.ReadLine();
    }
}
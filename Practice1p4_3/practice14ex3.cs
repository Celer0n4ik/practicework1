using System;
using System.IO;

class practice14ex3
{
    static void Main()
    {
        string[] numbers = File.ReadAllText("numsTask3.txt").Split(',');
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (string number in numbers)
        {
            int n = Convert.ToInt32(number);
            if (n != 0)
            {
                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }
            }
            else
            {
                break;
            }
        }

        if (min != int.MaxValue && max != int.MinValue)
        {
            double ratio = (double)min / max;
            Console.WriteLine("Отношение минимального и максимального элементов равно " + ratio);
        }
        else
        {
            Console.WriteLine("В последовательности нет чисел до 0");
        }
        Console.ReadLine();
    }
}
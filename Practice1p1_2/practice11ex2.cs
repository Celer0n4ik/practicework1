using System;
using System.Collections.Generic;

internal class practice11ex2
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        int input;
        do
        {
            Console.Write("Введите любое число (или 0 для завершения ввода): ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        while (input != 0);

        int sum = 0;
        int product = 1;

        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine("Сумма всех чисел: " + sum);
        Console.WriteLine("Произведение всех чисел: " + product);
        Console.WriteLine("Среднее арифметическое всех чисел: " + average);
        Console.ReadLine();
    }
}
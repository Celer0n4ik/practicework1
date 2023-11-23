using System;

class practice16ex4
{
    static void Main()
    {
        int a;
        int sum = 0;

        Console.WriteLine("Введите положительное число a: ");
        a = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            if (number % a == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine("Сумма чисел, делящихся на " + a + " нацело: " + sum);
        Console.ReadLine();
    }
}
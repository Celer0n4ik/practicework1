using System;

class practice16ex3
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine("Число четное и кратное 10.");
        }
        else
        {
            Console.WriteLine("Число нечетное и/или не кратное 10.");
        }
        Console.ReadLine();
    }
}
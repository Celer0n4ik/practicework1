using System;

class practice14ex6
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (a b): ");
        string[] input = Console.ReadLine().Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);

        if ((a >= -2 && a <= 2 && b >= -3 && b <= 2 && b >= -2 * a - 3 && b >= 2 * a - 3))
        {
            Console.WriteLine("Точка принадлежит заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит заштрихованной области");
        }
        Console.ReadLine();
    }
}
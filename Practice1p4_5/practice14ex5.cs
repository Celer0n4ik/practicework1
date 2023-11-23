using System;

class practice14ex5
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (a b): ");
        string[] input = Console.ReadLine().Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);

        if ((a >= -1 && a <= 3 && b >= -2 && b <= 4) || (a >= -1 && a <= 3 && b >= -2 && b <= 4))
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
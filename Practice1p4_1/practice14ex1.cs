using System;

class practice14ex1
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        Console.WriteLine("Произведение чисел, кратных трём и не превышающих " + n + " равно " + product);
        Console.ReadLine();
    }
}
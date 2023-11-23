using System;

internal class practice11ex1
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100);
        }

        Console.WriteLine("Массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        int minIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }

        Console.WriteLine("Номер минимального элемента массива: " + minIndex);
        Console.ReadLine();
    }
}
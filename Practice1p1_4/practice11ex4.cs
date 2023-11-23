using System;
using System.Collections.Generic;

public class practice11ex4
{
    public static void Main()
    {
        Console.WriteLine("Введите начало диапазона: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конец диапазона: ");
        int end = Convert.ToInt32(Console.ReadLine());
        
        int[] array = FillArray(start, end);
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.ReadLine();
    }
    
    public static int[] FillArray(int start, int end)
    {
        List<int> list = new List<int>();
        
        Random rand = new Random();
        for (int i = start; i <= end; i++)
        {
            list.Add(rand.Next(start, end + 1));
        }
        
        return list.ToArray();
    }
}
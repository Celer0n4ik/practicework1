using System;
using System.Collections.Generic;

public class practice12ex1
{
    public static void Main()
    {
        int[] collection = new int[100];
        int number = 300;

        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = number;
            number -= 3;
        }
        for (int i = 0; i < collection.Length; i++)
        {
            Console.Write(collection[i] + " ");
        }
        Console.ReadLine();
    }
}
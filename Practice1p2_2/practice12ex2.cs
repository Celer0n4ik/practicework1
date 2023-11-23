using System;
using System.Collections.Generic;

public class practice12ex2
{
    public static void Main()
    {
        int[] collection = new int[100];
        int number = 1;

        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = number;
            number += 2;
        }
        for (int i = 0; i < collection.Length; i++)
        {
            Console.Write(collection[i] + " ");
        }
        Console.ReadLine();
    }
}
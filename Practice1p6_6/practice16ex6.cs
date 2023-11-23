using System;

class practice16ex6
{
    static void Main()
    {
        double[] originalArray = { 1.5, -2.3, 4.7, -3.2, 0.8, -1.1 };
        
        int positiveCount = 0;
        int negativeCount = 0;
        
        foreach (double num in originalArray)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
        }
        
        double[] positiveArray = new double[positiveCount];
        double[] negativeArray = new double[negativeCount];
        
        int positiveIndex = 0;
        int negativeIndex = 0;
        
        foreach (double num in originalArray)
        {
            if (num > 0)
            {
                positiveArray[positiveIndex] = num;
                positiveIndex++;
            }
            else if (num < 0)
            {
                negativeArray[negativeIndex] = num;
                negativeIndex++;
            }
        }
        
        Console.WriteLine("Положительные элементы:");
        foreach (double num in positiveArray)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine("\nОтрицательные элементы:");
        foreach (double num in negativeArray)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }
}
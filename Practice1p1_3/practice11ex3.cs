using System;
using System.Collections.Generic;

internal class practice11ex3
{
    private static void Main()
    {
        List<string> words = new List<string>();

        string input;
        do
        {
            Console.Write("Введите любое слово (или нажмите 'Enter' для завершения ввода): ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                words.Add(input);
            }
        }

        while (!string.IsNullOrEmpty(input));

        string shortest = words[0];
        string longest = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortest.Length)
            {
                shortest = word;
            }
            else if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        Console.WriteLine("Кратчайшее слово в списке: " + shortest);
        Console.WriteLine("Длиннейшее слово в списке: " + longest);
        Console.ReadLine();
    }
}
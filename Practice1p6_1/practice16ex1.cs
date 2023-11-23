using System;
using System.IO;

class practice16ex1
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask1.txt");

        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word);
            }
        }
        Console.ReadLine();
    }
}
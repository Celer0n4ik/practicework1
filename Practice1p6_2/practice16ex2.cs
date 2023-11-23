using System;
using System.IO;

class practice16ex2
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask2.txt");
        string result = "";

        foreach (string word in words)
        {
            result += word + " ";
        }

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');
        int wordCount = words.Length;
        
        string newString = "Start " + input + " End";
        
        Console.WriteLine("Количество слов в строке: " + wordCount);
        Console.WriteLine("Новая строка: " + newString);
        Console.ReadLine();
    }
}
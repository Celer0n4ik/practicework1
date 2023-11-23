using System;
using System.IO;

class practice13ex2
{
    static void Main()
    {
        string fileContent = File.ReadAllText("nums.txt");
        string[] numbers = fileContent.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = Int32.Parse(numbers[i]);
            if (num % 2 == 0)
            {
                numbers[i] = "";
            }
        }

        string newContent = string.Join(" ", numbers);
        File.WriteAllText("nums.txt", newContent);
    }
}
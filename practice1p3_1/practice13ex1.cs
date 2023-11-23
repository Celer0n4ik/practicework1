using System;
using System.IO;

class practice13ex1
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");

        string[] chosenNumbersStr = lines[0].Split(' ');
        int[] chosenNumbers = Array.ConvertAll(chosenNumbersStr, int.Parse);

        int n = int.Parse(lines[1]);

        string[] output = new string[n];

        for (int i = 0; i < n; i++)
        {
            string[] ticketNumbersStr = lines[i + 2].Split(' ');
            int[] ticketNumbers = Array.ConvertAll(ticketNumbersStr, int.Parse);

            int count = 0;
            foreach (int number in ticketNumbers)
            {
                if (Array.IndexOf(chosenNumbers, number) != -1)
                {
                    count++;
                }
            }

            if (count >= 3)
            {
                output[i] = "Lucky";
            }
            else
            {
                output[i] = "Unlucky";
            }
        }

        File.WriteAllLines("output.txt", output);
    }
}
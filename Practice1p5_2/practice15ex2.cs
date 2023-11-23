using System;
using System.IO;
using System.Linq;

class practice15ex2
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask2.txt");
        string[] numbersStr = lines[0].Split(';');
        double[] numbers = Array.ConvertAll(numbersStr, double.Parse);

        Array.Sort(numbers);

        string sortedNumbers = string.Join(";", numbers.Select(n => n.ToString()).ToArray());

        File.WriteAllText("numsTask2.txt", sortedNumbers);
    }
}
using System;
using System.IO;
using System.Linq;

class practice15ex5
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask5.txt");
        string[] numbersStr = lines[0].Split(';');
        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int maxIndex = Array.IndexOf(numbers, numbers.Max());

        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);

        if (start == end)
        {
            Console.WriteLine("����� ����������� � ������������ ��� �����.");
            return;
        }

        int sum = 0;
        for (int i = start + 1; i < end; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / (end - start - 1);
        Console.WriteLine("������� �������������� ����� ����������� � ������������: " + average);
        Console.ReadLine();
    }
}
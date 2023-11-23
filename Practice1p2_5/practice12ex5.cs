using System;
using System.Collections.Generic;

class practice12ex5
{
    static void Main(string[] args)
    {
        Dictionary<string, int[]> temperature = GenerateTemperature();
        Dictionary<string, double> averageTemperatures = CalculateAverageTemperature(temperature);
        PrintAverageTemperatures(averageTemperatures);
        Console.ReadLine();
    }

    static Dictionary<string, int[]> GenerateTemperature()
    {
        Dictionary<string, int[]> temperature = new Dictionary<string, int[]>();
        Random random = new Random();

        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        foreach (string month in months)
        {
            int[] monthTemperature = new int[30];

            for (int i = 0; i < 30; i++)
            {
                monthTemperature[i] = random.Next(-10, 40);
            }

            temperature.Add(month, monthTemperature);
        }

        return temperature;
    }

    static Dictionary<string, double> CalculateAverageTemperature(Dictionary<string, int[]> temperature)
    {
        Dictionary<string, double> averageTemperatures = new Dictionary<string, double>();
        foreach (KeyValuePair<string, int[]> monthTemperature in temperature)
        {
            double sum = 0;

            foreach (int dayTemperature in monthTemperature.Value)
            {
                sum += dayTemperature;
            }

            double averageTemperature = sum / monthTemperature.Value.Length;
            averageTemperatures.Add(monthTemperature.Key, averageTemperature);
        }

        return averageTemperatures;
    }

    static void PrintAverageTemperatures(Dictionary<string, double> averageTemperatures)
    {
        Console.WriteLine("Average Temperatures:");
        foreach (KeyValuePair<string, double> monthTemperature in averageTemperatures)
        {
            Console.WriteLine($"{monthTemperature.Key}: {monthTemperature.Value}°C");
        }
    }
}

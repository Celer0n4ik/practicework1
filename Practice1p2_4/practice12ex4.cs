using System;

namespace AverageTemperature
{
    class practice12ex4
    {
        static void Main(string[] args)
        {
            int[,] temperature = new int[12, 30];
            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = random.Next(-10, 30);
                }
            }

            double[] averageTemperatures = CalculateAverageTemperature(temperature);

            Array.Sort(averageTemperatures);

            foreach (var temp in averageTemperatures)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }

        static double[] CalculateAverageTemperature(int[,] monthlyTemperatures)
        {
            double[] averages = new double[12];
            for (int i = 0; i < 12; i++)
            {
                double sum = 0;
                for (int j = 0; j < 30; j++)
                {
                    sum += monthlyTemperatures[i, j];
                }
                averages[i] = sum / 30;
            }
            return averages;
        }
    }
}
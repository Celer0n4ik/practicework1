using System;

class Program
{
    static void Main(string[] args)
    {
        int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int maxArea = MaxArea(heights);

        Console.WriteLine(maxArea);
        Console.ReadLine();
    }

    static int MaxArea(int[] heights)
    {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right)
        {
            int area = Math.Min(heights[left], heights[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
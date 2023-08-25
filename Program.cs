using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be empty or null.");

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numberArray = { 10, 20, 30, 40, 50 };

        double average = MathHelper.CalculateAverage(numberArray);

        Console.WriteLine($"Average: {average:F2}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT22
{
    static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
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
}

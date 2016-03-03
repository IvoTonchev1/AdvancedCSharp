using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Categorization
{
    class Categorization
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers: ");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            double[] numbers = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = double.Parse(arr[i]);
            }
            List<double> wholes = new List<double>();
            List<double> floats = new List<double>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    wholes.Add(numbers[i]);
                }
                else
                {
                    floats.Add(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("[" + string.Join(", ", wholes) + "] -> min: " + wholes.Min() + ", max: " + wholes.Max() + ", sum: " + wholes.Sum() + ", avg: {0:F2}", wholes.Average());
            Console.WriteLine();
            Console.WriteLine("[" + string.Join(", ", floats) + "] -> min: " + floats.Min() + ", max: " + floats.Max() + ", sum: " + floats.Sum() + ", avg: {0:F2}", floats.Average());
        }
    }
}

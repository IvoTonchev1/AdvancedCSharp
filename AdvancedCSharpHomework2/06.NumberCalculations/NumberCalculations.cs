using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers: ");
            int[] numbers = Console.ReadLine().Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine("Min: {0} \nMax: {1} \nSum: {2} \nAverage: {3}", GetMinimum(numbers), GetMaximum(numbers), GetSum(numbers), GetAverage(numbers));
        }

        static int GetMinimum(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static double GetMinimum(double[] arr)
        {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static decimal GetMinimum(decimal[] arr)
        {
            decimal min = decimal.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static int GetMaximum(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static double GetMaximum(double[] arr)
        {
            double max = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static decimal GetMaximum(decimal[] arr)
        {
            decimal max = decimal.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double GetSum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static decimal GetSum(decimal[] arr)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double GetAverage(int[] arr)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum/arr.Length;
            return avg;
        }

        static double GetAverage(double[] arr)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            return avg;
        }

        static decimal GetAverage(decimal[] arr)
        {
            decimal sum = 0;
            decimal avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            return avg;
        }
    }
}

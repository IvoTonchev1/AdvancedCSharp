using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string[] input = Console.ReadLine().Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char first = input[i][0];
                char second = input[i][input[i].Length - 1];
                double number = double.Parse(input[i].Substring(1, input[i].Length - 2));
                if (char.IsUpper(first))
                {
                    int front = first - 'A' + 1;
                    number /= front;
                }
                else
                {
                    int front = first - 'a' + 1;
                    number *= front;
                }
                if (char.IsUpper(second))
                {
                    int end = second - 'A' + 1;
                    number -= end;
                }
                else
                {
                    int end = second - 'a' + 1;
                    number += end;
                }
                result += number;
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] input =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            for (int i = 1; i < input.Length; i++)
            {
                int j = i;
                while (j > 0 && input[j] < input[j - 1])
                {
                    int temp = input[j];
                    input[j] = input[j - 1];
                    input[j - 1] = temp;
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

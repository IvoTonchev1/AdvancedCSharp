using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers: ");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int[] numbers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }
            int count = 0;
            int temp = 0;
            int ind = 0;
            Console.Write(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    Console.Write(" " + numbers[i]);
                    count++;
                    if (temp < count)
                    {
                        temp = count;
                        ind = i;
                    }
                }
                else
                {
                    Console.Write("\n" + numbers[i]);
                    count = 0;                  
                }
            }
            Console.WriteLine();
            Console.Write("Longest: ");
            for (int i = 0; i <= temp; i++)
            {
                Console.Write(numbers[ind - temp + i] + " ");
            }
            Console.WriteLine();
        }
    }
}

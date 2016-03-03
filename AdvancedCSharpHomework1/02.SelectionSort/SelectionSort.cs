using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SelectionSort
{
    class SelectionSort
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
            int min = int.MaxValue;
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        temp = j;
                    }
                }
                numbers[temp] = numbers[i];
                numbers[i] = min;
                min = int.MaxValue;
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

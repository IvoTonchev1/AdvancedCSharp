using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumbers
{
    class SortArrayOfNumbers
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
            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _1.BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers: ");
            string input = Console.ReadLine();
            string[] newInput = input.Split(' ');
            int[] numbers = new int[newInput.Length];
            for (int i = 0; i < newInput.Length; i++)
            {
                numbers[i] = int.Parse(newInput[i]);
            }
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length -1; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

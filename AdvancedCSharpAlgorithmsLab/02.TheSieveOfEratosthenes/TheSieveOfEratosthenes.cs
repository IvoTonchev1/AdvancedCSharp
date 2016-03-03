using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TheSieveOfEratosthenes
{
    class TheSieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[input + 1];
            int prime = 2;
            for (int i = 0; i <= input; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < input; i++)
            {
                if (numbers[i] < prime)
                {
                    continue;
                }
                else
                {
                    prime = i;
                    for (int j = 2; j < input; j++)
                    {
                        int n = j * prime;
                        if (numbers.Contains(n))
                        {
                            int index = Array.IndexOf(numbers, n);
                            numbers[index] = -1;
                        }
                    }
                }
            }
            string result = "";
            foreach (int number in numbers)
            {
                
                if (number != -1 && number != 1 && number != 0)
                {
                    result += number + ", ";
                }               
            }
            string output = result.Remove(result.Length - 2, 2);
            Console.WriteLine(output);
        }
    }
}

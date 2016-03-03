using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text:");
            string[] input =
                Console.ReadLine()
                    .Split(new char[] {',', ' ', '!', '?', '.'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            List<string> result = new List<string>();
            bool check = true;
            for (int i = 0; i < input.Length; i++)
            {
                check = true;
                for (int j = 0; j <= input[i].Length/2; j++)
                {
                    if (input[i][j] != input[i][input[i].Length - 1 - j])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    result.Add(input[i]);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

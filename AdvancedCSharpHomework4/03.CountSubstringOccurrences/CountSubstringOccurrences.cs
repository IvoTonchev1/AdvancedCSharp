using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text:");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter string:");
            string input = Console.ReadLine().ToLower();
            int count = 0;
            for (int i = 0; i <= text.Length - input.Length; i++)
            {
                if (text.Substring(i, input.Length) == input)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

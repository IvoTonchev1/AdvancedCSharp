using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequenceOfEqualStrings
{
    class SequenceOfEqualStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter words: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Console.Write(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Equals(words[i - 1]))
                {
                    Console.Write(" " + words[i]);
                }
                else
                {
                    Console.Write("\n" + words[i]);
                }
            }
            Console.WriteLine();
        }
    }
}

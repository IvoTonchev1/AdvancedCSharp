using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text:");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("u\\{0:x4}", (int)input[i]);              
            }
            Console.WriteLine();
        }
    }
}

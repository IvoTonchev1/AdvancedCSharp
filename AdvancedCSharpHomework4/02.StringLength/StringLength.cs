using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text:");
            string input = Console.ReadLine();
            char[] result = new char[20];
            if (input.Length >= 20)
            {               
                for (int i = 0; i < 20; i++)
                {
                    result[i] = input[i];
                }
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    if (input.Length > i)
                    {
                        result[i] = input[i];
                    }
                    else
                    {
                        result[i] = '*';
                    }
                }
            }
            foreach (var letter in result)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}

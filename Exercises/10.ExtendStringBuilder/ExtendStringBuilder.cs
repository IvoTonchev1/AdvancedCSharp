using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtendStringBuilder
{
    class ExtendStringBuilder
    {
        static void Main()
        {
            StringBuilder alphabet = new StringBuilder();
            for (int i = 'a'; i <= 'z'; i++)
            {
                alphabet.Append((char)i);
            }
            string firstTenLetters = alphabet.Substring(0, 10);
            Console.WriteLine(firstTenLetters);
        }
    }
}

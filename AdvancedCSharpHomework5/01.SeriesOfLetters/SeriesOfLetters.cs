using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string:");
            string input = Console.ReadLine();
            //  The regex will match any character (.) and \\1+ will match whatever was captured in the first group.
            Regex regex = new Regex(@"(.)\1+");
            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}

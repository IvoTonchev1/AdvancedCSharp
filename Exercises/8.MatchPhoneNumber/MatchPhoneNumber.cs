using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string numbers = "+359 2 222 2222, +359-2-222-2222, 359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2-222-2222, +359-2-222-222, +359-2-222-22222";
            string pattern = @"\B\+359(\s|\-)[\d]{1}(\1)[\d]{3}(\1)[\d]{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(numbers);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}

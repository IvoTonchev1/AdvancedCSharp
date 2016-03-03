using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string names = "Ivan Ivanov, ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	  Ivanov, Onufri Metodievstatiev";
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(names);
            foreach (var name in match)
            {
                Console.WriteLine(name);
            }
        }
    }
}

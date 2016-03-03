using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _9.CleanUpTheMess
{
    class CleanUpTheMess
    {
        static void Main(string[] args)
        {
            string text = "";
            StreamReader reader = new StreamReader("Mecanismo.cs");
            string line = reader.ReadLine();  
            while (line != null)
            {
                text += line;
                line = reader.ReadLine();
            }
            string pattern = @"[\s+\n\s+]";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, Environment.NewLine);

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            // read file HTML-AHref.txt saved in same folder as the project .cs file
            string html = File.ReadAllText(@"..\..\HTML-AHref.txt");

            string pattern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";

            // create new file
            using (StreamWriter URL = new StreamWriter(@"..\..\HTML-URL.txt"))
            {
                // write on the new file, the URL-replaced string
                URL.WriteLine(Regex.Replace(html, pattern, @"[URL$1]$3[/URL]"));
            }

            // print output file to the console
            string fileContents = File.ReadAllText(@"..\..\HTML-URL.txt");
            Console.WriteLine(fileContents);
        }
    }
}

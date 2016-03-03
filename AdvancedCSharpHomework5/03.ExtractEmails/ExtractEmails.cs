﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(text);

            // create new file
            using (StreamWriter URL = new StreamWriter(@"..\..\emails.html"))
            {
                foreach (Match email in matches)
                {
                    URL.WriteLine(String.Format("<i>" + email.Groups[1] + "</i>"));
                    URL.WriteLine("<br>");
                }
            }
            // open html file with results
            System.Diagnostics.Process.Start(@"..\..\emails.html");
        }
    }
}

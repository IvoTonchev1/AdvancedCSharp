using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../OddLines.cs"))
            {
                int counter = 0;
                var line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("{0,3}. {1}", counter, line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

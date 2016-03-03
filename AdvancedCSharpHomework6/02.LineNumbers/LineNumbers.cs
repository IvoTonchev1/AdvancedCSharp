using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../LineNumbers.cs"))
            {
                using (var writer = new StreamWriter("../../Result.txt"))
                {
                    int counter = 0;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine("{0,3}. {1}", counter, line);
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("File generated.");
        }
    }
}

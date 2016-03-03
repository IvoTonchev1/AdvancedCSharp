using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter ban words:");
            string[] banList = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine("Please enter text:");
            string text = Console.ReadLine();
            for (int i = 0; i < banList.Length; i++)
            {
                text = text.Replace(banList[i], new string('*', banList[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}

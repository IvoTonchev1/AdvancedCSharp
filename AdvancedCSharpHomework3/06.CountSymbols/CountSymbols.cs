using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char,int> result = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (result.ContainsKey(input[i]))
                {
                    result[input[i]]++;
                }
                else
                {
                    result.Add(input[i], 1);
                }
            }
            foreach (var symbol in result)
            {
                Console.WriteLine(symbol.Key + ": " + symbol.Value + " time/s");
            }
        }
    }
}

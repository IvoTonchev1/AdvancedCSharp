using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16.LittleJohn
{
    class LittleJohn
    {
        static void Main(string[] args)
        {
            const int N = 4;

            string arrowMatcher = "(>>>----->>)|(>>----->)|(>----->)";
            Regex rgx = new Regex(arrowMatcher);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.AppendFormat(" {0}", Console.ReadLine());
            }

            var arrows = rgx.Matches(sb.ToString());

            int smallAraowsCount = 0;
            int mediumArrowCount = 0;
            int largeArrowsCount = 0;

            foreach (Match match in arrows)
            {
                if (!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    largeArrowsCount++;
                }
                else if (!string.IsNullOrEmpty(match.Groups[2].Value))
                {
                    mediumArrowCount++;
                }
                else
                {
                    smallAraowsCount++;
                }
            }
  
            string numberAsString = String.Format("{0}{1}{2}", smallAraowsCount, mediumArrowCount, largeArrowsCount);

            int decNumber = int.Parse(numberAsString);

            string binNumber = Convert.ToString(decNumber, 2);
            string reversedBin = new string(binNumber.Reverse().ToArray());
            string totalBin = binNumber + reversedBin;

            int result = Convert.ToInt32(totalBin, 2);

            Console.WriteLine(result);
        }
    }
}

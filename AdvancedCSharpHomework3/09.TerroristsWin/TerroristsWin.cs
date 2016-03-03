using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TerroristsWin
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            // get first index
            int firstIndex = text.IndexOf('|');
            int secondIndex = 0;
            int ASCIISum = 0;
            int spreadArea = 0;

            while (firstIndex != -1)
            {
                // get second index
                secondIndex = text.IndexOf('|', firstIndex + 1);

                // calculate bomb power
                int bombLength = secondIndex - (firstIndex + 1);
                string bomb = text.Substring(firstIndex + 1, bombLength);
                ASCIISum = bomb.ToCharArray().Select(c => (int)c).Sum();
                spreadArea = ASCIISum % 10;

                // adjust start and end indexes to text length
                int startIndex = firstIndex - spreadArea;
                int endIndex = secondIndex + spreadArea;
                startIndex = startIndex > 0 ? startIndex : 0;
                endIndex = endIndex < text.Length ? endIndex : text.Length - 1;

                // total destryed area
                int destroyedArea = endIndex - startIndex + 1;

                // replace destroyed area with dots
                text = text.Remove(startIndex, destroyedArea).Insert(startIndex, new string('.', destroyedArea));

                // check if next first index exists
                firstIndex = text.IndexOf('|', secondIndex + 1);
            }

            Console.WriteLine(text);
        }
    }
}

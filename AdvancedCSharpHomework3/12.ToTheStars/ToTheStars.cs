using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ToTheStars
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] second = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] third = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double[] initcoord = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double x = initcoord[0];
            double y = initcoord[1];
            int moves = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i <= moves; i++)
            {
                if ((x >= double.Parse(first[1]) - 1) && (x <= double.Parse(first[1]) + 1) && (y >= double.Parse(first[2]) - 1) && (y <= double.Parse(first[2]) + 1))
                {
                    Console.WriteLine(first[0].ToLower());
                }
                else if ((x >= double.Parse(second[1]) - 1) && (x <= double.Parse(second[1]) + 1) && (y >= double.Parse(second[2]) - 1) && (y <= double.Parse(second[2]) + 1))
                {
                    Console.WriteLine(second[0].ToLower());
                }
                else if ((x >= double.Parse(third[1]) - 1) && (x <= double.Parse(third[1]) + 1) && (y >= double.Parse(third[2]) - 1) && (y <= double.Parse(third[2]) + 1))
                {
                    Console.WriteLine(third[0].ToLower());
                }
                else
                {
                    Console.WriteLine("space");
                }
                y++;
            }
        }
    }
}

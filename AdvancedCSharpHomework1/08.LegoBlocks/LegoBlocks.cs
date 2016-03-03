using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool fit = true;
            int[][] left = new int[n][];
            int[][] right = new int[n][];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                left[i] = Console.ReadLine().Split(new char[] { ',', ';', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sum += left[i].Length;
            }
            int rowLenght;
            for (int i = 0; i < n; i++)
            {
                right[i] = Console.ReadLine().Split(new char[] { ',', ';', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sum += right[i].Length;
                rowLenght = left[0].Length + right[0].Length;
                if (!(left[i].Length + right[i].Length == rowLenght))
                {
                    fit = false;
                }
            }
            if (fit)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("[{0}, {1}]", string.Join(", ", left[i]), string.Join(", ", right[i].Reverse()));
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}", sum);
            }
        }
    }
}

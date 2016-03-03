using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SnakeLikeMatrix
{
    class SnakeLikeMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first dimension:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second dimension:");
            int columns = int.Parse(Console.ReadLine());
            int[,] result = new int[rows, columns];
            int count = 1;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (i%2 == 0)
                    {
                        result[i, j] = count;
                        count++;
                    }
                    else
                    {
                        result[i, columns - j - 1] = count;
                        count++;
                    }
                }
            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write("{0,4}", result[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

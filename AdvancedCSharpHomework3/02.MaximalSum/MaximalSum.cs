using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            int[,] matrix = new int[rows,columns];
            int sum = 0;
            int[,] result = new int[3,3];
            int bestRow = 0;
            int bestCol = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < columns - 2; j++)
                {
                    if (sum < matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2])
                    {
                        sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] +
                              matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] +
                              matrix[i + 2, j + 2];
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                for (int j = bestCol; j < bestCol + 3; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

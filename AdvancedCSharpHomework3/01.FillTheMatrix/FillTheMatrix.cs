using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first dimension: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter second dimension: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] result = MakeFirstMatrix(rows, columns);
            int[,] resultTwo = MakeSecondMatrix(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0,4}", result[i,j]);                 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0,4}", resultTwo[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int[,] MakeFirstMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows,cols];
            int count = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {                    
                    matrix[i,j] = count;
                    count += cols;
                }
                count = i + 2;
            }
            return matrix;
        }

        static int[,] MakeSecondMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int count = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i%2 != 0)
                    {
                        matrix[j, i - 1] = count;
                        count ++;
                    }
                    else
                    {
                        matrix[cols - j - 1,i - 1] = count;
                        count++;
                    }
                }
            }
            return matrix;
        }
    }
}

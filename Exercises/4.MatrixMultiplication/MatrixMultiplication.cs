using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MatrixMultiplication
{
    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            int[,] matrixOne = new int[,] {{2,3},{1,5}};
            int[,] matrixTwo = new int[,] {{2,3},{1,5}};
            if (matrixOne.GetLength(1) != matrixTwo.GetLength(0))
            {
                Console.WriteLine("Cannot multiply matrices.");
                return;
            }
            int[,] result = new int[matrixOne.GetLength(0),matrixTwo.GetLength(1)];
            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    result[row, col] = MultiplyRowByColumn(matrixOne, matrixTwo, row, col);
                }
            }
            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    Console.Write("{0,4}", result[row, col]);                  
                }
                Console.WriteLine();
            }
        }

        static int MultiplyRowByColumn(int[,] matrixOne, int[,] matrixTwo, int row, int col)
        {
            int sum = 0;
            for (int i = 0; i < matrixOne.GetLength(1); i++)
            {
                sum += matrixOne[row, i]*matrixTwo[i, col];
            }
            return sum;
        }
    }
}

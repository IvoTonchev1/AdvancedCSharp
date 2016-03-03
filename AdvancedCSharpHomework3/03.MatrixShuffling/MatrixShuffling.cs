using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            string temp = "";
            string line = Console.ReadLine();
            while (line != "END")
            {
                Console.WriteLine();
                string[] arr = line.Split(' ');
                if (arr.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    line = Console.ReadLine();
                    continue;
                }
                int x1 = int.Parse(arr[1]);
                int y1 = int.Parse(arr[2]);
                int x2 = int.Parse(arr[3]);
                int y2 = int.Parse(arr[4]);
                if ((arr[0] != "swap") || (x1 < 0) || (x1 > rows - 1) || (x2 < 0) || (x2 > rows - 1) || (y1 < 0) || (y1 > columns - 1) || (y2 < 0) || (y2 > columns - 1))
                {
                    Console.WriteLine("Invalid input!");
                    line = Console.ReadLine();
                    continue;
                }
                temp = matrix[x1, y1];
                matrix[x1, y1] = matrix[x2, y2];
                matrix[x2, y2] = temp;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i, j] + " ");                       
                    }
                    Console.WriteLine();
                }
                line = Console.ReadLine();
            }
        }
    }
}

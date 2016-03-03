using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            for (int i = 0; i < 4; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                board[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {                        
                    board[i][j] = input[j];
                }
            }
            string coms = Console.ReadLine();
            char[] commands = new char[coms.Length];
            for (int i = 0; i < coms.Length; i++)
            {
                commands[i] = coms[i];
            }
            int coins = 0;
            int walls = 0;          
            int currentRow = 0;
            int currentCol = 0;            
            for (int i = 0; i < commands.Length; i++)
            {
                char position = board[currentRow][currentCol];
                if (position == '$')
                {
                    coins++;
                    board[currentRow][currentCol] = 's';
                }

                if (commands[i] == '>' && board[currentRow].Length - 1 > currentCol)
                {
                    currentCol++;
                }
                else if (commands[i] == '<' && currentCol > 0)
                {
                    currentCol--;
                }
                else if (commands[i] == '^' && currentRow > 0 && board[currentRow - 1].Length > currentCol)
                {
                    currentRow--;
                }
                else if (commands[i] == 'V' && currentRow < 4 && board[currentRow + 1].Length > currentCol)
                {
                    currentRow++;
                }
                else
                {
                    walls++;
                }
            }
            Console.WriteLine("Coins collected: " + coins);
            Console.WriteLine();
            Console.WriteLine("Walls Hit: " + walls);
        }
    }
}

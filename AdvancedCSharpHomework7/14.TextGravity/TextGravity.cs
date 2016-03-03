using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _14.TextGravity
{
    class TextGravity
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char[] line = Console.ReadLine().ToCharArray();

            int N = (int)Math.Ceiling((double)line.Length / length);
            int M = length;
            string[,] table = new string[N, M];
            int index = 0;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    if (index < line.Length)
                    {
                        table[row, col] = line[index].ToString();
                        index++;
                    }
                    else
                    {
                        table[row, col] = " ";
                    }
                }
            }
            bool fallen = false;

            do
            {
                fallen = false;
                for (int row = 0; row < N - 1; row++)
                {
                    for (int col = 0; col < M; col++)
                    {
                        if (table[row, col] != " " && table[row + 1, col] == " ")
                        {
                            table[row + 1, col] = table[row, col];
                            table[row, col] = " ";
                            fallen = true;
                        }
                    }
                }
            } while (fallen);

            Console.Write("<table>");
            for (int row = 0; row < N; row++)
            {
                Console.Write("<tr>");
                for (int col = 0; col < M; col++)
                {
                    Console.Write("<td>{0}</td>", SecurityElement.Escape(table[row, col]));
                }
                Console.Write("</tr>");
            }
            Console.Write("</table>");
        }
    }
}

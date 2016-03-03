using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BePositive
{
    class BePositive
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                List<int> numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        Console.Write("{0}{1}", currentNum, j == numbers.Count - 1 ? "\n" : " ");
                        found = true;
                    }
                    else if (currentNum < 0 && j < numbers.Count - 1)
                    {
                        currentNum += numbers[j + 1];
                        //numbers.Remove(j + 1);
                        j++;
                        if (currentNum >= 0)
                        {
                            Console.Write("{0}{1}",currentNum, j == numbers.Count - 1 ? "\n" : " ");
                            found = true;
                        }
                        else if (currentNum < 0 && j == numbers.Count - 1 && found)
                        {
                            Console.WriteLine();
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}

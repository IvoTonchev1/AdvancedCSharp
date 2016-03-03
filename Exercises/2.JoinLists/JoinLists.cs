using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first list: ");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter second list: ");
            string second = Console.ReadLine();
            string[] newFirst = first.Split(' ');
            string[] newSecond = second.Split(' ');
            int[] listOne = new int[newFirst.Length];
            int[] listTwo = new int[newSecond.Length];
            for (int i = 0; i < newFirst.Length; i++)
            {
                listOne[i] = int.Parse(newFirst[i]);
            }
            for (int i = 0; i < newSecond.Length; i++)
            {
                listTwo[i] = int.Parse(newSecond[i]);
            }
            List<int> result = new List<int>();
            for (int i = 0; i < listOne.Length; i++)
            {
                if (result.Contains(listOne[i]))
                {
                    continue;
                }
                result.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.Length; i++)
            {
                if (result.Contains(listTwo[i]))
                {
                    continue;
                }
                result.Add(listTwo[i]);
            }
            result.Sort();
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}

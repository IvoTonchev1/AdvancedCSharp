using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayTest
{
    class ArrayTest
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] line = Console.ReadLine().Split(' ').ToArray();

            while (!line[0].Equals("stop"))
            {
 
                int[] args = new int[2];

                if (line[0].Equals("add") ||
                    line[0].Equals("subtract") ||
                    line[0].Equals("multiply"))
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);
                    
                    array = PerformAction(array, line[0], args);
                }
                else if (line[0].Equals("lshift"))
                {
                    array = ArrayShiftLeft(array);
                }
                else
                {
                    array = ArrayShiftRight(array);
                }

                PrintArray(array);
                line = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }
            return array;
        }

        private static long[] ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
            return array;
        }

        private static long[] ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
            return array;
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array) + " ");
        }
    }
}

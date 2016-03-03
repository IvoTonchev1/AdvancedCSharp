using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array:");
            int[] nums = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(nums, i));
            }
        }

        static bool IsLargerThanNeighbours(int[] arr, int pos)
        {
            bool check = false;
            if (pos == 0 && arr.Length > 1)
            {
                if (arr[pos] > arr[pos + 1])
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            else if (pos == arr.Length - 1 && arr.Length > 1)
            {
                if (arr[pos] > arr[pos - 1])
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            else if (arr.Length > 3)
            {
                if ((arr[pos] > arr[pos - 1]) && (arr[pos] > arr[pos + 1]))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
    }
}

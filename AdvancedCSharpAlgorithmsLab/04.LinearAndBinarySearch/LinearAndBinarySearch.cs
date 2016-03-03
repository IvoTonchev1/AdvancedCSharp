using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LinearAndBinarySearch
{
    class LinearAndBinarySearch
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(LinearSearch(input, number));
            //Console.WriteLine(BinarySearch(input, number));
        }

        static int BinarySearch(int[] arr, int element)
        {
            Array.Sort(arr);
            int result = -1;
            int min = 0;
            int max = arr.Length - 1;
            while (max > min)
            {               
                int mid = min + (max - min)/2;
                if (arr[mid] == element)
                {
                    result = mid;
                    break;
                }
                if (arr[mid] < element)
                {
                    min = arr.Length/2 + 1;
                }
                else if(arr[mid] > element)
                {                   
                    max = max/2 - 1;
                }
                
            }
            return result;
        }

        static int LinearSearch(int[] arr, int element)
        {
            int result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}

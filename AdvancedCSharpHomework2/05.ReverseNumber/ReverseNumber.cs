using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(number);
            Console.WriteLine(reversed);
        }

        static double GetReversedNumber(double num)
        {
            string one = num.ToString();
            char[] mid = one.ToCharArray();
            Array.Reverse(mid);
            string two = new string(mid);
            double result = double.Parse(two);
            return result;
        }
    }
}

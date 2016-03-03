using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrimeFactorizations
{
    class PrimeFactorization
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = input;
            List<int> result = new List<int>();
            int divisor = 2;
            if (input < 2)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                while (input > 1)
                {
                    if (input % divisor == 0)
                    {
                        input /= divisor;
                        result.Add(divisor);
                    }
                    else
                    {
                        divisor++;
                    }
                }            
            }
            result.Sort();
            Console.WriteLine("{0} = {1}", output, string.Join(" * ", result));
        }
    }
}

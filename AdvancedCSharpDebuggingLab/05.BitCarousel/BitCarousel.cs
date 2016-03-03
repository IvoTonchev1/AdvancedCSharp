using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitCarousel
{
    class BitCarousel
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            byte rotations = byte.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    byte rightMostBit = (byte)(number & 1);
                    number >>= 1;
                    number |= (byte)(rightMostBit << 5);
                }
                else if (direction == "left")
                {
                    int leftMostBit = (byte)((number >> 5) & 1);
                    number <<= 1;
                    number |= (byte)leftMostBit;
                    if (((number >> 6) & 1) == 1)
                    {
                        number ^= 64;
                    }
                }
            }

            Console.WriteLine(number);
        }
    }
}

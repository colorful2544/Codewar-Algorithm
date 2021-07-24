using System.Text;
using System;
using System.Collections;

namespace Bit_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(10));

        }
        public static int CountBits(int n)
        {
            BitArray a = new BitArray(BitConverter.GetBytes(n));
            int result = 0;
            foreach (bool b in a)
            {
                if (b == true)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}

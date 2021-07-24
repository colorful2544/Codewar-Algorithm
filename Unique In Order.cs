using System;
using System.Linq;
using System.Collections.Generic;

namespace Unique_In_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach(var i in UniqueInOrder("AAAABBBCCDAABBB")) // output : ABCDAB
            {
                Console.Write(i);
            }
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            string charState = "";

            List<T> a = new List<T>();

            foreach (var item in iterable)
            {
                if(item.ToString() != charState)
                {
                    charState = item.ToString();
                    a.Add(item);
                }
            }
            return a.AsEnumerable();
        }
    }
}
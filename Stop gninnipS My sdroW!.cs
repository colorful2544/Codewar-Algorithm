using System.Collections.Generic;
using System;

namespace Stop_gninnipS_My_sdroW_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("You are almost to the last test"));
        }

        public static string SpinWords(string sentence)
        {
            string[] strSplit = sentence.Split(" ");
            List<string> strResult = new List<string>();
            foreach(string item in strSplit)
            {
                if(item.Length >= 5) 
                {
                    char[] strReverse = item.ToCharArray();
                    Array.Reverse(strReverse);

                    strResult.Add(String.Join("",strReverse));
                }
                else 
                {
                    strResult.Add(item);
                }
            }
            return String.Join(" ",strResult.ToArray());
        }
    }
}

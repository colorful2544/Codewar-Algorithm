using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace Simple_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(PigIt("Hello world !"));
        }
        public static string PigIt(string str)
        {
            return Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
        }
        
        public static string PigIt2(string str)
        {
            string[] strSplit = str.Split(" ");
            string[] strResult = new string[strSplit.Length];
            int count = 0;

            Regex regex = new Regex("[a-zA-Z]");

            foreach(string strItem in strSplit)
            {
                if(regex.IsMatch(strItem))
                {
                    char[] strToChar = strItem.ToCharArray();
                    char firstChar = strToChar[0];

                    List<char> charDel = new List<char>();
                    foreach(char charItem in strToChar)
                    {
                        charDel.Add(charItem);
                    }
                    charDel.RemoveAt(0);

                    string newStr = $"{String.Join("",charDel.ToArray())}{firstChar}ay";

                    strResult[count] = newStr;

                }
                else 
                {
                    strResult[count] = strItem;
                }
                count++;
            }

            return String.Join(" ",strResult);
        }
    }
}

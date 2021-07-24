using System.Text.RegularExpressions;
using System;

namespace PascalCase_string_into_snake_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToUnderscore("Am7Days"));
        }
        public static string ToUnderscore(int str)
        {
            return $"{str}";
        }

        public static string ToUnderscore(string str)
        {
            string[] charac = new string[str.Length];
            for(int index = 0; index < charac.Length; index++)
            {
                charac[index] = str[index].ToString();
            }

            for(int index = 1; index < charac.Length; index++)
            {
                int a = 0;
                bool checkNumber = int.TryParse(charac[index],out a);
                if(charac[index] == charac[index].ToUpper() && checkNumber == false)
                {
                    charac[index] = $"_{charac[index]}";
                }
            }
            return String.Join("",charac).ToLower();
        }
    }
}

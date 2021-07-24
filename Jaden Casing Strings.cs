using System;

namespace Jaden_Casing_Strings
{
    class Program
    {
        /*
            โจทย์ : ทำให้ข้อความใน string เป็น Jaden-Cased

            Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
            Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
        */
        static void Main(string[] args)
        {
            string text = ToJadenCase("How can mirrors be real if our eyes aren't real");
            Console.WriteLine(text);
        }
        static string ToJadenCase(string phrase)
        {
            string[] oldString = phrase.Split(" ");
            string newStr = "";

            for(int i = 0; i < oldString.Length; i++)
            {
                oldString[i] = oldString[i].Substring(0,1).ToUpper() + oldString[i].Substring(1,oldString[i].Length - 1);
            }
            
            newStr = string.Join(" ",oldString);

            return newStr;
        }
    }
}

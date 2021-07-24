using System;

namespace Find_the_missing_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingLetter(new char[] {'a','b','c','d','f'}));
        }
        public static char FindMissingLetter(char[] array)
        {
            string characAll = "";

            for(char character = array[0]; character <= array[array.Length - 1]; character++)
            {
                characAll += character;
            }

            char[] newChar = characAll.ToCharArray();
            
            int count = 0;
            char result = '\0';
            while(true)
            {
                if(array[count] != newChar[count])
                {
                    result = newChar[count];
                    break;
                }
                else 
                {
                    count++;
                }
            }

            return result;
        }
    }
}

using System;

namespace Create_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}));
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            string strNumbers = String.Join("",numbers);
            return $"({strNumbers.Substring(0,3)}) {strNumbers.Substring(3,3)}-{strNumbers.Substring(6,4)}";
        }
    }
}

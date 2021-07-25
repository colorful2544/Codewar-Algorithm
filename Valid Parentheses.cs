
using System;
using System.Linq;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses("()"));
        }
        public static bool ValidParentheses(string input)
        {
            int score = 0;
            foreach(char i in input)
            {
                if(i == '(') score++;
                if(i == ')') score--;
                if(score < 0) return false;
            }
            return score == 0;
        }
    }
}

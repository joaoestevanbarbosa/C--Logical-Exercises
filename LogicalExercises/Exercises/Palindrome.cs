using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class Palindrome
    {
        public static void Execute()
        {
            string text = string.Empty;

            text = "joao";
            Console.WriteLine("Is Palindrome \"{0}\"={1}", text, IsPalindrome(text));

            text = "arara";
            Console.WriteLine("Is Palindrome \"{0}\"={1}", text, IsPalindrome(text));
        }

        protected static bool IsPalindrome(string text)
        {
            //Program to check if a string is Palindrome or not in C#.

            //Palindrome strings: kayak, level, peeweep, refer, sexes, Kinikinik, Ward Draw, Wassamassaw

            char[] chars = text.ToCharArray();

            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
                {
                if (chars[i] != chars[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

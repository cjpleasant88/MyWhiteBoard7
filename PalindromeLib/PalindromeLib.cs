using System;

namespace PalindromeLib
{
    public class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            input = input.ToLower();
            int palinIndex = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[palinIndex--])
                    return false;
            }
            return true;
        }
    }
}
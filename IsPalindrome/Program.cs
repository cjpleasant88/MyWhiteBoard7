using System;

namespace IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IsPalindrome.Program.Main()\n");
            Console.Write("What is the string you would like to check: ");
            string input = Console.ReadLine();
            bool isPalindrome = IsPalindrone(input);
            if (isPalindrome == true)
            {
                Console.WriteLine($"YES, The string {input} is a Palindrome!");
            }
            else
            {
                Console.WriteLine($"The string {input} is NOT a Palindrome!");
            }
        }

        public static bool IsPalindrone(string input)
        {
            input = input.ToLower();
            string reverseInput = "";
            for (int i = (input.Length - 1); i >= 0; --i)
            {
                reverseInput += input[i];
            }
            return reverseInput == input;
        }
    }
}

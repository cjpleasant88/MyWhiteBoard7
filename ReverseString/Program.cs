using System;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReverseString.Program.Main()\n");
            Console.Write("What is the string you would like to reverse: ");
            string input = Console.ReadLine();
            string reverseInput = GetReverse(input);
            Console.WriteLine($"The reverse of {input} is {reverseInput}");
        }

        public static string GetReverse(string input)
        {
            string reverseInput = "";
                for(int i = (input.Length-1); i >= 0; --i)
            {
                reverseInput += input[i];
            }
            return reverseInput;
            
        }
    }
}

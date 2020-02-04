using System;

namespace ContinueLoop
{
    public class Program
    {

        public static int Position(char a, string input)
        {
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == a)
                    return (i+1);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Which string do you want to look at: ");
            string input = Console.ReadLine();
            Console.WriteLine("What character are you searching for: ");
            char a = Convert.ToChar(Console.ReadLine());
            int position = Position(a, input);
            if (position == 0)
            {
                Console.WriteLine($"Letter {a} is not in {input}");
            }
            else
            {
                Console.WriteLine($"Letter '{a}' is in '{input}' at position [{position}]");
            }
           
        }
    }
}
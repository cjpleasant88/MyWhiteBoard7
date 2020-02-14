using System;

namespace AlphaOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Today is the thirtennth of February";
            Console.WriteLine(input);
            Console.WriteLine(AlphaOrder(input));

            Console.WriteLine("");

            input = "bbbbbbccssssa";
            Console.WriteLine(input);
            Console.WriteLine(AlphaOrder(input));

            Console.ReadLine();
        }

        public static string AlphaOrder(string input)
        {
            input = input.ToLower();
            string output = "";
            for (int i  = 'a'; i <= 'z'; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == i)
                    {
                        output += input[j];
                        break;
                    }
                }
            }
            return output;
        }
    }
}

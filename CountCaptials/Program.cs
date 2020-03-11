using System;


namespace CountCapitals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tCounting the number of capital letter sin a string");
            string input = "Hello World!";
            Console.WriteLine($"\nString Testing = {input}");
            Console.WriteLine();
            Console.WriteLine("IsUpper method");
            Console.WriteLine(CountCaptials(input));
            Console.WriteLine("Within ASCII range Method");
            Console.WriteLine(CountCaptials2(input));
            Console.WriteLine("Within char range Method");
            Console.WriteLine(CountCaptials3(input));
        }

        public static int CountCaptials(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return 0;
            }
            int count = 0;
            foreach(char c in input)
            {
                if(char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountCaptials2(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 64 && input[i] < 91 )
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountCaptials3(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    count++;
                }
            }
            return count;
        }
    }
}

using System;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many vowels in a string.");

            //2 stop watches used to time the two different ways of counting vowels
            var watch = new System.Diagnostics.Stopwatch();
            var watch2 = new System.Diagnostics.Stopwatch();

            //Declares and assigns "input" as a very long string
            string input = "";
            for (int i = 0; i < 10000; i++)
            {
                input += ";owhfPCGDOYh+fPCGDOYgUls;owhfPCGDOYUlsnv;ajnd;knfkjaen;rogushdzoyiclha;likf;jh;bkjrweh,gb;lkrsnav;iulSDKXZCGo";
            }

            //Calculates the time using IF Statements
            watch.Start();
            Console.WriteLine(VowelCount(input));
            watch.Stop();
            Console.WriteLine($"Execution time for **IF** version: {watch.ElapsedMilliseconds} ms");

            Console.WriteLine("");
            Console.WriteLine("");

            //Calculates the time using SWITCH Statement
            watch2.Start();
            Console.WriteLine(VowelCount2(input));
            watch2.Stop();
            Console.WriteLine($"Execution time for **SWITCH** version: {watch2.ElapsedMilliseconds} ms");
        }

        //IF Method of counting vowels
        public static string VowelCount(string input)
        {
            input = input.ToLower();
            int count = 0;
            if ( string.IsNullOrEmpty(input))
            {
                return "Error: String is Empty or Null.";
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a'|| input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    count++;
                }
            }
            return count.ToString();
        }

        //Switch method of counting Vowels
        public static string VowelCount2(string input)
        {
            input = input.ToLower();
            int count = 0;
            if (string.IsNullOrEmpty(input))
            {
                return "Error: String is Empty or Null.";
            }
            for (int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                    default:
                        break;
                }
            }
            return count.ToString();
        }
    }
}

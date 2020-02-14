using System;

namespace IsPrime
{
    public class IsPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tisPrime.Program.Main()");

            for (long i = 100000000000; ;++i)
                {
                if (IsPrime.isPrime(i))
                {
                    Console.WriteLine(i);
                }
                }
            /*
            Console.WriteLine("\nI will test if a given number is Prime");
            Console.Write("\nPlease enter a number you would like to check: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (isPrime(input))
            {
                Console.WriteLine($"\nYes, {input} is a Prime Number!");
            }
            else
            {
                Console.WriteLine($"\nNo, {input} is NOT a Prime Number...");
            }
            */
        }

        public static bool isPrime(long input)
        {
            if (input < 2) return false;
            for (long i = 2; i < input/2; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

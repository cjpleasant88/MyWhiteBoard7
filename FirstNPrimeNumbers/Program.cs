using System;

namespace FirstNPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FirstNPrimeNumbers.Program.Main()");

            Console.WriteLine("\nThis will print a list of a user defined number of prime numbers.");
            Console.Write("\nHow many prime numbers do you want to print: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\tThe first {input} prime numbers:");
            NPrimeNumberss(input);
        }

        public static void NPrimeNumberss(int n)
        {
            int primeCounter = 2;
            int numberOfPrimes = 0;

            while (numberOfPrimes < n)
            {
                if (isPrime(primeCounter))
                {
                    numberOfPrimes++;
                    Console.WriteLine($"{numberOfPrimes})\t{primeCounter}");
                    numberOfPrimes++;
                }
                primeCounter++;
            }
        }

        public static bool isPrime(int input)
        {
            if (input < 2) return false;
            for (int i = 2; i < input; i++)
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

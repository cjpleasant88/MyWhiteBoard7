using System;

namespace SumOfPrimes
{
    public class SumOfPrimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\nThis will return the sum of a user defined prime numbers.");
            Console.Write("\nHow many prime numbers do you want to sum: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\tThe sum of {input} prime numbers = {SumOfNPrimes(input)}");
        }

        public static long SumOfNPrimes(int n)
        {
            int PrimeSum = 0;
            int numberToTest = 2;
            int numberOfPrimes = 0;

            while (numberOfPrimes < n)
            {
                if(isPrime(numberToTest))
                {
                    PrimeSum += numberToTest; //1, 2, 3, 5, 7, 11
                    numberOfPrimes++;
                }
                numberToTest++;
            }
            return PrimeSum;
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

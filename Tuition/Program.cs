using System;

namespace Tuition
{
    class Program
    {
        public static void DisplayAnnualTuitionCost()
        {
            decimal tuition = 6000M;

            for (int year = 0; year < 5; year++)
            {
                Console.WriteLine($"For year {year + 1} your tuition will be {tuition}");
                tuition *= 1.02M;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("tuition.Program.Main()\n");
            DisplayAnnualTuitionCost();
        }
    }
}

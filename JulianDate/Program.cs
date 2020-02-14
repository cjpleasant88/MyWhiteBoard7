using System;

namespace JulianDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Julian day calculator given two integers, a month and a day");

            Console.Write("\nWhat is your month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nWhat is your day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            int julianDate = JulianDate(month, day);

            Console.WriteLine($"\nYour Julian Day = {julianDate}");
        }

        public static int JulianDate(int month, int day)
        {
            int julianDate = 0;
            while (month > 0)
            {
                switch (month - 1)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        julianDate += 31;
                        break;
                    case 2:
                        julianDate += 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        julianDate += 30;
                        break;
                    default:
                        Console.WriteLine("\nThat date does not exist");
                        break;
                }
                month--;
            }
            julianDate += day;

            return julianDate;
        }

    }
}

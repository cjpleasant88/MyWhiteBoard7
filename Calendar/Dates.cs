using System;

namespace Calendar
{
    public class Dates
    {
        public static int JulianDay(int mon, int day)
        {
            int julianDate = 0;
            while (mon > 0)
            {
                switch (mon - 1)
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
                mon--;
            }
            julianDate += day;

            return julianDate;
        }
    }
}

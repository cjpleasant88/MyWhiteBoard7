using System;

 namespace AngleOfClockHands
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(HandsAngle(1,45));
        }

        public static int HandsAngle(int hour, int minute)
        {

            //adjusts for 24 hour time input
            if(hour > 12)
            {
                hour = 24 - hour;
            }

            //Declares the angles of hour, minute, and the differnce between them
            int angleDifference;
            int hourAngle = (360 / 12) * hour;
            int handAngle = (360 / 60) * minute;

            //changes the hour angle in the case it is 12 or 24
            if (hourAngle == 360)
            {
                hourAngle = 0;
            }

            //
            angleDifference = Math.Abs(hourAngle - handAngle);

            if(angleDifference > 180)
            {
                angleDifference = 360 - angleDifference;
            }
            return angleDifference;
        }
    }
}

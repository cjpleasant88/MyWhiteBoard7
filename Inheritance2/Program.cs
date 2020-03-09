using System;

namespace Inheritance2
{
    public class Horse
    {
        //Fields
        string color;

        //Constructor
        public Horse()
        {
            color = "brown";
        }

        public Horse(string horseColor)
        {
            this.color = horseColor;
        }

        //Mehtod to set Color
        public void SetColor(string newColor)
        {
            this.color = newColor;
        }

        //Method to Retrieve the color
        public string GetColor()
        {
            return this.color;
        }
    }

    //Main Class
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            Horse MrEd = new Horse();
            Horse Pokey = new Horse();
            Horse Trigger = new Horse("white");

            Pokey.SetColor("red");
            //Trigger.color = "white"; //Cannot so anymore now that color is a private field
            //Trigger.SetColor("white"); //Don't have to use anymore because Trigger was created using non-default constructor
            
            Console.WriteLine($"MrEd is a {MrEd.GetColor()} horse.");
            Console.WriteLine($"Pokey is a {Pokey.GetColor()} horse.");
            Console.WriteLine($"Trigger is a {Trigger.GetColor()} horse.");
        }
    }
}

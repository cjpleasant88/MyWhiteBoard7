using System;


namespace TestArea
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine(string.Format("Hello {0}!!", name));
        }
    }
}

using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tTesting of a String Extension Method that Counts the number of capitals in the string.");
			//TEST CASES:
			string input1 = "Hello World!";
			string input2 = null;
			string input3 = "";
			string input4 = "This is a test of the National Broadcasting System";
			string input5 = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			//OUTPUT:
			Console.WriteLine($"\"{input1}\" has {input1.CountCap()} Capital Letters");
			Console.WriteLine($"\"{input2}\" has {input2.CountCap()} Capital Letters");
			Console.WriteLine($"\"{input3}\" has {input3.CountCap()} Capital Letters");
			Console.WriteLine($"\"{input4}\" has {input4.CountCap()} Capital Letters");
			Console.WriteLine($"\"{input5}\" has {input5.CountCap()} Capital Letters");
		}
    }

    public static class Extensions
	{
		public static int CountCap(this string input)
		{
			int max = 100;
			int count = 0;


			if (string.IsNullOrEmpty(input))
			{
				return -1;
			}

			if (input.Length > max) // TODO;
			{
				return -1;
			}

			for (int i = 0; i < input.Length; i++)
			{
				//if(this.input[i] <= 'Z' && this.input[i] >= 'A') //Add comments when ri

				if (char.IsUpper(input[i]))
				{
					count++;
				}
			}
			return count;
		}
	}
}

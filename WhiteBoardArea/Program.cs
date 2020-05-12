using System;
using System.Collections.Generic;
using System.Threading;

//Objective: Given an array of numbers, output in a sorted manner
//Can be ascending or descending

//input = int[] input
//max length = 100
//output = int[] sorted

namespace WhiteBoardArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tScrabble Point Values");

			do
			{
				Console.WriteLine();
				string Apple = "Apple";
				string dog = "Dog";
				string wordWithBlank = "MS A";
				Console.Write("What is your word: ");
				string input = Console.ReadLine();
				//Console.WriteLine($"The total value of your word {Apple} is {ScrabbleWordScore(Apple)}!");
				//Console.WriteLine($"The total value of your word {dog} is {ScrabbleWordScore(dog)}!");
				//Console.WriteLine($"The total value of your word {wordWithBlank} is {ScrabbleWordScore(wordWithBlank)}!");
				Console.WriteLine($"The total value of your word {input} is {ScrabbleWordScore(input)}!");
			} while (true);
		}


		public static int ScrabbleWordScore(string word)
		{
			word = word.ToUpper();

			int score = 0;

			Dictionary<char, int> letterPoint = new Dictionary<char, int>();
			letterPoint.Add('A', 1);
			letterPoint.Add('B', 3);
			letterPoint.Add('C', 3);
			letterPoint.Add('D', 2);
			letterPoint.Add('E', 1);
			letterPoint.Add('F', 4);
			letterPoint.Add('G', 2);
			letterPoint.Add('H', 4);
			letterPoint.Add('I', 1);
			letterPoint.Add('J', 8);
			letterPoint.Add('K', 5);
			letterPoint.Add('L', 1);
			letterPoint.Add('M', 3);
			letterPoint.Add('N', 1);
			letterPoint.Add('O', 1);
			letterPoint.Add('P', 3);
			letterPoint.Add('Q', 10);
			letterPoint.Add('R', 1);
			letterPoint.Add('S', 1);
			letterPoint.Add('T', 1);
			letterPoint.Add('U', 1);
			letterPoint.Add('V', 4);
			letterPoint.Add('W', 4);
			letterPoint.Add('X', 8);
			letterPoint.Add('Y', 4);
			letterPoint.Add('Z', 10);
			letterPoint.Add(' ', 0);

			for(int i = 0; i < word.Length; i++)
			{
				score += letterPoint[word[i]];
			}
			return score;
		}

public static int[] ArraySort(int[] input, bool ascending = true)
		{
			if (input.Length > 100)
			{
				throw new Exception();
			}

			int temp;

			if (ascending)
			{
				for (int i = 0; i < input.Length - 1; i++)
				{
					for (int j = i + 1; j < input.Length; j++)
					{
						if (input[i] > input[j])
						{
							temp = input[i];
							input[i] = input[j];
							input[j] = temp;
						}
					}
				}
			}
			else
			{
				for (int i = 0; i < input.Length - 1; i++)
				{
					for (int j = i + 1; j < input.Length; j++)
					{
						if (input[i] < input[j])
						{
							temp = input[i];
							input[i] = input[j];
							input[j] = temp;
						}
					}
				}
			}
			return input;
		}
	}
}

using System;
using System.IO;
using System.Collections.Generic;

//How many Lines are there
//How many Lines are blank
//How many lines have text
//Did step 5 count every line, blank or not
//How wmany words are in the text file
//How many distinct words are there int the text file
//Which words are the most frequently used
//How many times
//Open a new file for writing
//Out put each word, on a different line, that occurs more than one time along with number of occurances

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string filePath = @"C:/jungle.txt";
            ReadTextFile(filePath);
        }

        public static void ReadTextFile(string filePath)
        {
            //display the file path
            Console.WriteLine(filePath);

            int lineCount = 0;
            int blankLineCount = 0;
            int wordCount = 0;
            string text = "";
            List<string> words = new List<string>();

            //array of each line
            string[] lines = System.IO.File.ReadAllLines(filePath);
            //string of all lyrics
            text = System.IO.File.ReadAllText(filePath);
     
            //words.Add()


            //displays how many lines there are
            lineCount = text.Split("\n").Length;

            //Splits the text on new line symbol and counts the blank lines
            foreach (var s in text.Split("\n"))
            {
                if (s.Length < 1)
                {
                    blankLineCount++;
                }
            }
            var wordss = text.Split(" ");
            Console.WriteLine($"# of words = {wordss.Length}");

            //foreach ( var word in words)
            //{
            //    if (!wo)
            //}

            //split text file by space symbol and counts words
            wordCount = text.Split(" ").Length;

            Console.WriteLine($"Line Count: {lineCount}");
            Console.WriteLine($"Blank Line Count: {blankLineCount}");
            Console.WriteLine($"Word Count: {wordCount}");
        }
    }
}

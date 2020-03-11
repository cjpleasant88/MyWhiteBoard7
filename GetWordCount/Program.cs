using System;

namespace GetWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tGetWordCount method\n\n");

            string input = "Hello my name is Caleb Pl3asant";
            Console.WriteLine(input);
            Console.WriteLine(GetWordCount(input));
        }

        public static int GetWordCount(string input = "")
        {
            // Input Validation
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            // Length Validation
            if (input.Length > 200)
            {
                //invalid length
                return -1;
            }

            input = input.ToUpper();

            bool isWord = false;

            int wordCount = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                //Check if the current character is space
                if (input[i].Equals(' '))
                {
                    //Check if that was the end of a word
                    if (isWord)
                    {
                        wordCount++;
                    }

                    //Reset the word flag
                    isWord = false;
                }
                else
                {

                    //Continuation of word
                    if (input[i] >= 'A' && input[i] <= 'Z')
                    {
                        isWord = true;
                    }
                    else
                    {
                        isWord = false;
                    }
                }
            }

            if (isWord)
            {
                //Count the last word
                wordCount++;
            }
            return wordCount;
        }
    }
}
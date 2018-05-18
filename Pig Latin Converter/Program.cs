using System;

namespace Pig_Latin_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string userInput;
            string pigLatinOutput;
            string statement;

            Console.Write("Enter a phrase to convert to Pig Latin:");
            userInput = Console.ReadLine().ToString();
            ConvertInput(userInput);
            Console.ReadKey();
        }
        // Method to convert English to Pig Latin
        public static string ConvertInput(string statement)
        {
            // Split statement into a string array separated by spaces.
            string[] words = statement.Split(' ');
            int wordCount = words.Length;
            string separator = " ";
            string[] conversionString = new string[words.Length];
            string[] pigLatinPhrase = new string[words.Length];

            // Convert each word to Pig Latin.
            foreach (var item in words)
            {
                // TODO: create method to convert string to Pig Latin.
            }

            // Print each word in the console.
            for (int i = 0; i < wordCount - 1; i++)
            {
                Console.Write(words[i] + separator);
            }

            Console.Write(words[wordCount - 1]);

            return statement;
        }
    }
}

using System;

namespace Pig_Latin_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a phrase to convert to Pig Latin:");
            string userInput = Console.ReadLine().ToString();
            ConvertInput(userInput);
            Console.ReadKey();
        }
        // Method to convert English to Pig Latin
        public static string ConvertInput(string statement)
        {
            // Split statement into a string array separated by spaces.
            string[] words = statement.Split(' ');
            int wordCount = words.Length;
            string[] conversionString = new string[words.Length];
            string[] pigLatinPhrase = new string[words.Length];

            // Convert each word to Pig Latin.
            foreach (string item in words)
            {
                // Create an English word, convert it to Pig Latin,
                // then display it on the screen.
                string englishWord = item.ToString().ToLower();
                string pigLatinWord = englishWord.Substring(1);
                Console.Write(pigLatinWord + englishWord.Substring(0,1) + "ay ");
            }

            return statement;
        }
    }
}

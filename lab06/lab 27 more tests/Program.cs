using System;

namespace Tests
{
    class Eng35Tests
    {
        static void Main()
        {
           string string01 = "why what a lovely array of words you have here";

            Console.WriteLine(CreateArrayFromSentence(string01));
            Console.WriteLine(GetWordsFromSentence(string01));
        }
        



        //pass in sentence and return array of individual words
        public static string[] CreateArrayFromSentence(string inputString)
        {
            string[] words = inputString.Split(' ');
            return new string[]
            {

            };
            
        }
        //pass in sentence and return number of words
        public static int GetWordsFromSentence(string inputString)
        {
            int wordCount = 0;
            string[] words = inputString.Split(' ');
            foreach(var word in words)
            {
                wordCount++;
            }
                return wordCount;
        }
        // "this is a sentence" returns "This Is A Sentence"
        public static string TurnFirstWordToUpperCase( string inputString)
        {
            
            string[] words = inputString.Split(' ');
            foreach (var word in words)
            {
                foreach (char c in word)
                {
                    if(c == word[0])
                    {
                        c.ToString().ToUpper();
                    }
                    
                }
            }
            return words[];
        }
        // "this is a sentence" returns "THIS is a sentence"
        public static string TurnAllWordsToUppercaseButLastWordToLowercase(string inputString)
        {
            return "";
        }
        // "this is a sentence" returns "THIS IS A SENTENCE"

    }
}

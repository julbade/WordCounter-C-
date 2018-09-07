using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
  public class RepeatCounter
  {
        public static int countWords(string wordToFind, string sentenceInput)
        {
            StringBuilder stringBuilder = new StringBuilder();

            //Loop through each character in the sentence including " "
            int count = 0;
            foreach (char word in sentenceInput) 
            {
                //Extracts each words in a sentence
                stringBuilder.Append(word);
                if (word == ' ')
                {
                    if (stringBuilder.ToString().Trim() == wordToFind)
                    {
                        count++;
                    }
                    stringBuilder.Clear();
                }
            }
            //To count last word to find
            if (stringBuilder.ToString().Trim() == wordToFind)
            {
                count++;
            }
            return count;
        }
       public static void Main()
        {

            Console.WriteLine("Please enter a word:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Please enter a sentence:");
            string userSentence = Console.ReadLine();
            Console.WriteLine(countWords(userInput, userSentence));

           
        }

    }
}

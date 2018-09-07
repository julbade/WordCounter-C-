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


            int count = 0;
            foreach (char word in sentenceInput) 
            {
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
            return count;
        }
       public static void Main()
        {

            Console.WriteLine(countWords("sample", "This sample is a sample hello"));
        }

    }
}

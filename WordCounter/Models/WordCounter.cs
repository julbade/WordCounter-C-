using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
        public static int countWords(string wordToFind, List<string> words)
        {
            int count = 0;
            foreach (string word in words) {
                if(wordToFind == word)
                {
                    count++; 
                }
            }
            return count;
        }
    
    }
}

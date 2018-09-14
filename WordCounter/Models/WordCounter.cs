using System;
using System.Collections.Generic;
using System.Text;


namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _inputSentence;
    private int _countWords

    public RepeatCounter (string word, string inputSentence)
    {
      _word = word;
      _inputSentence = inputSentence;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word.ToLower();

    }
    public void SetSentence(string inputSentence)
    {
      _inputSentence = inputSentence;
    }

    public string GetSentence()
    {
      return _inputSentence;

    }
    public void SetCountWords(int countWords)
    {
      _countWords = countWords;
    }
    public int GetCountWords()
    {
      return _countWords;
    }

    public static int WordsToCount(string wordToFind, string sentenceInput)
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
  }
}

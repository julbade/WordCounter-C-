using System;
using System.Collections.Generic;
using System.Text;


namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _inputSentence;
    private int _countWords;

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
      return _inputSentence.ToLower();

    }
    public void SetCountWords(int countWords)
    {
      _countWords = countWords;
    }
    public int GetCountWords()
    {
      return _countWords;
    }
    public static string[] WordsArray(string text)
    {

      char[] DeleteCharacters = new char[] {'.',',',';',':','?','!',' '};
      string[] newInputSentence = text.Split(DeleteCharacters);
      return newInputSentence;
    }

    public static int CountWords(string wordToFind, string[] inputSentence)
    {
     int count = 0;
     foreach(string word in inputSentence)
     {
       if (word == wordToFind)
       {
         count++;
       }
     }
       return count;
    }
 }
}

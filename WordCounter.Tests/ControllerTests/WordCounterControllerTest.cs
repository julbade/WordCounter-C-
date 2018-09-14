using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {
      [TestMethod]
    public void CountWords_ReturnCount_True()
    {

         //Arrange
         RepeatCounter Word = new RepeatCounter(" "," ");
         Word.SetWord("sample");
         Word.SetSentence("This sample is a sample");
         string sentenceInput = Word.GetSentence();
         string[] WordsArray = RepeatCounter.WordsArray(sentenceInput);
         string word = Word.GetWord();

         int expectedValue = 2;

         //Act
         int actualValue = RepeatCounter.CountWords(word,WordsArray);

        //Assert
        Assert.AreEqual(expectedValue, actualValue);
    }

  }
}

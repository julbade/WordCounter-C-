using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
        [TestMethod]
    public void countWords_NumberofWords()
        {
            //Arrange
            string wordToFind = "sample";
            string sentenceInput = "This sample is a sample hello";
            int expectedValue = 2;

            //Act
            int actualValue = RepeatCounter.countWords(wordToFind, sentenceInput);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

  }
}

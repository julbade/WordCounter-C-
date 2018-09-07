using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    int count = 0;
    List<string> testList = new List<string> {"sample", "sample"};
    WordCounter testCount = new WordCounter();

    [TestMethod]
    public void  WordCount_TestNumberofSample()
    {
      foreach(string x in WordCounter.WordCount())
      {
        if (x == "sample")
        count ++;
      }
      Assert.AreEqual(1, count);
    }

  }
}

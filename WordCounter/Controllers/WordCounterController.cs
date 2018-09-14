using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
      [HttpGet("/words")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/words/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/words")]
      public ActionResult Create()
      {
        RepeatCounter newWord = new RepeatCounter(Request.Form["new-word"],Request.Form["new-sentence"]);

       string[] wordsArray = RepeatCounter.WordsArray(newWord.GetWord());
       int wordCount = RepeatCounter.CountWords(newWord.GetWord(),wordsArray);
       newWord.SetCountWords(wordCount);
       return View("Result", newWord);
      }
    }
}

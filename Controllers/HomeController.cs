using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult WelcomePage(string word)
    {
      Game newGame = new Game(word);
      return View(newGame);
    }
  }
}
  

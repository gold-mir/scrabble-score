using Microsoft.AspNetCore.Mvc;
using System;
using Application.Models;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/score")]
        public int ReturnScore(string data)
        {
            Console.WriteLine($"Input = {data}");
            int score = ScrabbleScore.GetWordScore(data);
            return score;
        }
    }
}

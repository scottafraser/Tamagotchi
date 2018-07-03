using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpGet("/game")]
        public ActionResult Game()
        {
            return View("Game");
        }

        [HttpPost("/game")]
        public ActionResult GamePost()
        {
            Item newName = new Item(Request.Form["new-name"]);
                                 
            return View("Game", newName);
        }

        [HttpGet("/feed")]
        public ActionResult Feed()
        {
            return View();
        }

        [HttpGet("/play")]
        public ActionResult Play()
        {
            return View();
        }

        [HttpGet("/sleep")]
        public ActionResult Sleep()
        {
            return View();
        }




    }
}
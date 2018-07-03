using Microsoft.AspNetCore.Mvc;

namespace TamagotchiGame.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpGet("/game")]
        public ActionResult Game()
        {
            return View();
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
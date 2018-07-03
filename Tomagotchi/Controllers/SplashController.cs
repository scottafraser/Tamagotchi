using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class SplashController : Controller
    {
        [HttpGet("/")]
        public ActionResult SplashPage()
        {
            return View();
        }


    }
}
using Microsoft.AspNetCore.Mvc;

namespace TamagotchiGame.Controllers
{
    public class HomeController : Controller
    {
        public string Hello() { return "Hello friend!"; }
    }
}
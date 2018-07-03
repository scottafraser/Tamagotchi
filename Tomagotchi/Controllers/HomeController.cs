using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

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
            List<Item> petStatus = Item.GetAll();
            return View(petStatus[0]);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimTimGame.Web.Models;

namespace TimGame.Web.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StoryScene(int? nextPageNum)
        {
            var db = new TimGameDbContext();

            var model = db.Pages.Find(nextPageNum ?? 2);

            return View(model);
        }


    }
}
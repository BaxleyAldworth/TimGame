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

        public ActionResult StoryScene(int? pageNum)
        {
            var db = new ApplicationDbContext();

            var model = db.Pages.Find(pageNum ?? 2);

            return View(model);
        }
    }
}
using System.Linq;
using System.Web.Mvc;
using TimGame.Web.Models;

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

            if (nextPageNum == null)
            {
                nextPageNum = db.Pages.Min(x => x.Id);
            }


            var page = db.Pages.Find(nextPageNum);

            var model = new PageVM
            {
                BackgroundUrl = page.BackgroundUrl,
                NextPageId = page.NextPageId,
                
                CharactersOnPage = from c in page.CharactersOnPage
                                   select new CharactersOnPageVM
                                   {
                                       Id = c.Id,
                                       Name = c.Name,
                                       PositionX = c.PositionX,
                                       PositionY = c.PositionY
                                   },


                //CharactersOnPage = page.CharactersOnPage, //TODO make characters on page a VM and pull only what is needed.


                Phrases = from p in p.Phrases
                          select new PhraseVM
                                {
                                    Id = p.Id,
                                    EnglishText = p.EnglishText,
                                    ChineseText = p.ChineseText,
                                    Order = p.Order,
                                    CharacterId = p.Id,
                                    CharacterName = p.Name
                                }
            };

            return View(model);
        }
    }


    /*

    public ActionResult StoryText(int nextTextNum)
    {
        var db = new TimGameDbContext();

        var model = db.Texts.Find(nextTextNum);

        return View(model);
    }

*/
}
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TimGame.Web.Models
{
    public class PageVM
    {
        public int? NextPageId { get; set; }
        public IEnumerable<CharactersOnPageVM> CharactersOnPage { get; set; } = new List<CharactersOnPageVM>();
        public string BackgroundUrl { get; set; }
        public IEnumerable<PhraseVM> Phrases { get; set; } = new List<PhraseVM>();
        public string NextPageButtonText { get; set; }
        //public int CurrentPageId { get; set; }
    }

    public static class GameHelpers
    {
        public const int MaxGameX = 100;
        public const int MaxGameY = 25;

        public static int GetRealX(this int gameX, int worldXMax, int worldXOffSet, float scale = 1.0f)
        {
            return (int)((worldXMax / (float)MaxGameX) * scale * gameX + worldXOffSet);
        }

        public static int GetRealY(this int gameY, int worldYMax, int worldYOffSet, float scale = 1.0f)
        {
            return (int)((worldYMax / (float)MaxGameY) * scale * gameY + worldYOffSet);
        }
    }

}
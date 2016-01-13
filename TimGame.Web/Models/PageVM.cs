using System.Collections.Generic;

namespace TimGame.Web.Models
{
    public class PageVM
    {
        public int? NextPageId { get; set; }
        public string BackgroundUrl { get; set; }
        public IEnumerable<PhraseVM> Phrases { get; set; } = new List<PhraseVM>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Text
    {
        public int Id { get; set; }
        public string EnglishText { get; set; }
        public string ChineseText { get; set; }
        public virtual Character NPC { get; set; }
        public int Order { get; set; }

    //since each npc will appear only on a single page,
    //if you know the npc you know the page
}
}
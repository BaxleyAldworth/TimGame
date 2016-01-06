using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Page
    {
        public int ID { get; set; }
        public virtual Page NextPage { get; set; }
        public virtual Character NPConPage { get; set; }
        
        public string Title { get; set; }
        public string BackgroundUrl { get; set; }
        //public virtual ICollection<Choice> Choices { get; set; }
    }
}
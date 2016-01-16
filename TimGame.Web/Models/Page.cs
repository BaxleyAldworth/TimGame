using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        public int? NextPageId { get; set; }
        public virtual ICollection<Character> CharactersOnPage { get; set; } = new List<Character>();
        public string Title { get; set; }
        public string BackgroundUrl { get; set; }
        //public virtual ICollection<Choice> Choices { get; set; }
    }
}
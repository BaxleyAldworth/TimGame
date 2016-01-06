using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Battle
    {
        public int ID { get; set; }
        public List<Character> Characters { get; set; }
        public string Text { get; set; }
    }
}
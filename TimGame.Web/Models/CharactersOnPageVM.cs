using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class CharactersOnPageVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
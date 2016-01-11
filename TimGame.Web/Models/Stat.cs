using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Stat
    {
        public virtual Character Character { get; set; }
        public int Id { get; set; }
        public int TotalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Power { get; set; }
        public int Quickness { get; set; }
        public int Attack { get; set; }
        public int AC { get; set; }

        //Maybe later:
        //public int MP { get; set; }
        //public int Cunning { get; set; }
    }
}

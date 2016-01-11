using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public virtual ICollection<Item> EquippedItems { get; set; }
        public virtual ICollection<Item> InventoryItems { get; set; }
        public virtual Stat Stats { get; set; }
        public bool IsNPC { get; set; }
        public virtual Text Text { get; set; }
        public virtual Page PageShownOn { get; set; }
        //Characters include the characters you control
        //and the enemies you'll be fighting


        //ICollection lets you add add, remove, count etc.
        //For generally, use the one will create the lowest barrier to entry for what you need to do
        //virtual is for the lazy loading, if you don't put virtual on it you have to populate it up front~
    }
}
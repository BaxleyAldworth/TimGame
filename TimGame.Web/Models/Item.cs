using System.Collections.Generic;

namespace TimGame.Web.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Stat Stats { get; set; }
        public Character Character { get; set; }
        public bool IsEquipped { get; set; }
        
        //Character / NPC is who holds the item
    }
}
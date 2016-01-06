using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimGame.Web.Models
{
    public class Choice
    {
        public int ID { get; set; }
        public string PlayerChoiceText { get; set; }
        public string TranslatedChoiceText { get; set; }
        
    }
}
namespace TimGame.Web.Models
{
    public  class PhraseVM
    {
        public int Id { get; set; }
        public string EnglishText { get; set; }
        public string ChineseText { get; set; }
        public int Order { get; set; }
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
    }
}
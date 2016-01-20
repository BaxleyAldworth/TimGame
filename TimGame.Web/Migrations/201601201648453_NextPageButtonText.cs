namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextPageButtonText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "NextPageButtonText", c => c.String());
            DropColumn("dbo.Pages", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pages", "Title", c => c.String());
            DropColumn("dbo.Pages", "NextPageButtonText");
        }
    }
}

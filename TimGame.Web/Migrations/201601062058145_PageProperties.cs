namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PageProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "Title", c => c.String());
            AddColumn("dbo.Pages", "BackgroundUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "BackgroundUrl");
            DropColumn("dbo.Pages", "Title");
        }
    }
}

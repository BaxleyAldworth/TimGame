namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePropNames : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pages", new[] { "NextPage_ID" });
            DropIndex("dbo.Items", new[] { "Character_ID" });
            DropIndex("dbo.Items", new[] { "Stats_ID" });
            CreateIndex("dbo.Pages", "NextPage_Id");
            CreateIndex("dbo.Items", "Character_Id");
            CreateIndex("dbo.Items", "Stats_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Items", new[] { "Stats_Id" });
            DropIndex("dbo.Items", new[] { "Character_Id" });
            DropIndex("dbo.Pages", new[] { "NextPage_Id" });
            CreateIndex("dbo.Items", "Stats_ID");
            CreateIndex("dbo.Items", "Character_ID");
            CreateIndex("dbo.Pages", "NextPage_ID");
        }
    }
}

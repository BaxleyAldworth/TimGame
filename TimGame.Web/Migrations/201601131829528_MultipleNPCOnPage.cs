namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MultipleNPCOnPage : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Characters", new[] { "NPCPageId" });
            RenameColumn(table: "dbo.Characters", name: "NPCPageId", newName: "PageShownOn_Id");
            AlterColumn("dbo.Characters", "PageShownOn_Id", c => c.Int());
            CreateIndex("dbo.Characters", "PageShownOn_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Characters", new[] { "PageShownOn_Id" });
            AlterColumn("dbo.Characters", "PageShownOn_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Characters", name: "PageShownOn_Id", newName: "NPCPageId");
            CreateIndex("dbo.Characters", "NPCPageId");
        }
    }
}

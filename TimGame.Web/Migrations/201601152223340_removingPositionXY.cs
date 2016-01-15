namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingPositionXY : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Characters", name: "PageShownOn_Id", newName: "Page_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_PageShownOn_Id", newName: "IX_Page_Id");
            AddColumn("dbo.Characters", "PageShownOn", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "PageShownOn");
            RenameIndex(table: "dbo.Characters", name: "IX_Page_Id", newName: "IX_PageShownOn_Id");
            RenameColumn(table: "dbo.Characters", name: "Page_Id", newName: "PageShownOn_Id");
        }
    }
}

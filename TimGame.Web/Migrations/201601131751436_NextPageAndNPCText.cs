namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextPageAndNPCText : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pages", "NextPage_Id", "dbo.Pages");
            DropIndex("dbo.Pages", new[] { "NextPage_Id" });
            DropIndex("dbo.Texts", new[] { "NPCCharacterId" });
            RenameColumn(table: "dbo.Texts", name: "NPCCharacterId", newName: "NPC_Id");

            RenameColumn("dbo.Pages","NextPage_Id", "NextPageId");

            AlterColumn("dbo.Texts", "NPC_Id", c => c.Int());
            CreateIndex("dbo.Texts", "NPC_Id");
            
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Pages", "NextPageId", "NextPage_Id");

            DropIndex("dbo.Texts", new[] { "NPC_Id" });
            AlterColumn("dbo.Texts", "NPC_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Texts", name: "NPC_Id", newName: "NPCCharacterId");
            CreateIndex("dbo.Texts", "NPCCharacterId");
            CreateIndex("dbo.Pages", "NextPage_Id");
            AddForeignKey("dbo.Pages", "NextPage_Id", "dbo.Pages", "Id");
        }
    }
}

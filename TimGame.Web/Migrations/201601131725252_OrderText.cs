namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Texts", "Order", c => c.Int(nullable: false,defaultValue: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Texts", "Order");
        }
    }
}

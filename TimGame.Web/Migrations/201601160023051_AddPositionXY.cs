namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPositionXY : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "PositionX", c => c.Int(nullable: false, defaultValue: 550));
            AddColumn("dbo.Characters", "PositionY", c => c.Int(nullable: false, defaultValue: 183));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "PositionY");
            DropColumn("dbo.Characters", "PositionX");
        }
    }
}

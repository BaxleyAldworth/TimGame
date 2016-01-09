namespace TimGame.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        BackgroundUrl = c.String(),
                        NextPage_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pages", t => t.NextPage_ID)
                .Index(t => t.NextPage_ID);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsNPC = c.Boolean(nullable: false),
                        NPCPageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pages", t => t.NPCPageId)
                .Index(t => t.NPCPageId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsEquipped = c.Boolean(nullable: false),
                        Character_ID = c.Int(),
                        Stats_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Characters", t => t.Character_ID)
                .ForeignKey("dbo.Stats", t => t.Stats_ID)
                .Index(t => t.Character_ID)
                .Index(t => t.Stats_ID);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalHP = c.Int(nullable: false),
                        CurrentHP = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Quickness = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        AC = c.Int(nullable: false),
                        CharacterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Characters", t => t.CharacterId)
                .Index(t => t.CharacterId);
            
            CreateTable(
                "dbo.Texts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EnglishText = c.String(),
                        ChineseText = c.String(),
                        NPCCharacterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Characters", t => t.NPCCharacterId)
                .Index(t => t.NPCCharacterId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Texts", "NPCCharacterId", "dbo.Characters");
            DropForeignKey("dbo.Stats", "CharacterId", "dbo.Characters");
            DropForeignKey("dbo.Characters", "NPCPageId", "dbo.Pages");
            DropForeignKey("dbo.Items", "Stats_ID", "dbo.Stats");
            DropForeignKey("dbo.Items", "Character_ID", "dbo.Characters");
            DropForeignKey("dbo.Pages", "NextPage_ID", "dbo.Pages");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Texts", new[] { "NPCCharacterId" });
            DropIndex("dbo.Stats", new[] { "CharacterId" });
            DropIndex("dbo.Items", new[] { "Stats_ID" });
            DropIndex("dbo.Items", new[] { "Character_ID" });
            DropIndex("dbo.Characters", new[] { "NPCPageId" });
            DropIndex("dbo.Pages", new[] { "NextPage_ID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Texts");
            DropTable("dbo.Stats");
            DropTable("dbo.Items");
            DropTable("dbo.Characters");
            DropTable("dbo.Pages");
        }
    }
}

namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filefolder2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FolderPrivacies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FolderID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        SubRoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Folders", "FolderPrivacy_ID", c => c.Int());
            AddColumn("dbo.Roles", "FolderPrivacy_ID", c => c.Int());
            AddColumn("dbo.Users", "FolderPrivacy_ID", c => c.Int());
            AddColumn("dbo.SubRoles", "FolderPrivacy_ID", c => c.Int());
            CreateIndex("dbo.Folders", "FolderPrivacy_ID");
            CreateIndex("dbo.Roles", "FolderPrivacy_ID");
            CreateIndex("dbo.SubRoles", "FolderPrivacy_ID");
            CreateIndex("dbo.Users", "FolderPrivacy_ID");
            AddForeignKey("dbo.Folders", "FolderPrivacy_ID", "dbo.FolderPrivacies", "ID");
            AddForeignKey("dbo.Roles", "FolderPrivacy_ID", "dbo.FolderPrivacies", "ID");
            AddForeignKey("dbo.SubRoles", "FolderPrivacy_ID", "dbo.FolderPrivacies", "ID");
            AddForeignKey("dbo.Users", "FolderPrivacy_ID", "dbo.FolderPrivacies", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "FolderPrivacy_ID", "dbo.FolderPrivacies");
            DropForeignKey("dbo.SubRoles", "FolderPrivacy_ID", "dbo.FolderPrivacies");
            DropForeignKey("dbo.Roles", "FolderPrivacy_ID", "dbo.FolderPrivacies");
            DropForeignKey("dbo.Folders", "FolderPrivacy_ID", "dbo.FolderPrivacies");
            DropIndex("dbo.Users", new[] { "FolderPrivacy_ID" });
            DropIndex("dbo.SubRoles", new[] { "FolderPrivacy_ID" });
            DropIndex("dbo.Roles", new[] { "FolderPrivacy_ID" });
            DropIndex("dbo.Folders", new[] { "FolderPrivacy_ID" });
            DropColumn("dbo.SubRoles", "FolderPrivacy_ID");
            DropColumn("dbo.Users", "FolderPrivacy_ID");
            DropColumn("dbo.Roles", "FolderPrivacy_ID");
            DropColumn("dbo.Folders", "FolderPrivacy_ID");
            DropTable("dbo.FolderPrivacies");
        }
    }
}

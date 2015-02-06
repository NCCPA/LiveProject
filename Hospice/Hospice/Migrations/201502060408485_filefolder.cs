namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filefolder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "folderID", "dbo.Folders");
            DropForeignKey("dbo.Roles", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.SubRoles", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.Users", "Folder_ID", "dbo.Folders");
            DropIndex("dbo.Files", new[] { "folderID" });
            DropIndex("dbo.Roles", new[] { "Folder_ID" });
            DropIndex("dbo.SubRoles", new[] { "Folder_ID" });
            DropIndex("dbo.Users", new[] { "Folder_ID" });
            AddColumn("dbo.Folders", "FileName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Folders", "FileDescription", c => c.String(maxLength: 100));
            DropColumn("dbo.Folders", "RoleID");
            DropColumn("dbo.Folders", "UserID");
            DropColumn("dbo.Folders", "SubRoleID");
            DropColumn("dbo.Roles", "Folder_ID");
            DropColumn("dbo.SubRoles", "Folder_ID");
            DropColumn("dbo.Users", "Folder_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Folder_ID", c => c.Int());
            AddColumn("dbo.SubRoles", "Folder_ID", c => c.Int());
            AddColumn("dbo.Roles", "Folder_ID", c => c.Int());
            AddColumn("dbo.Folders", "SubRoleID", c => c.Int(nullable: false));
            AddColumn("dbo.Folders", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Folders", "RoleID", c => c.Int(nullable: false));
            DropColumn("dbo.Folders", "FileDescription");
            DropColumn("dbo.Folders", "FileName");
            CreateIndex("dbo.Users", "Folder_ID");
            CreateIndex("dbo.SubRoles", "Folder_ID");
            CreateIndex("dbo.Roles", "Folder_ID");
            CreateIndex("dbo.Files", "folderID");
            AddForeignKey("dbo.Users", "Folder_ID", "dbo.Folders", "ID");
            AddForeignKey("dbo.SubRoles", "Folder_ID", "dbo.Folders", "ID");
            AddForeignKey("dbo.Roles", "Folder_ID", "dbo.Folders", "ID");
            AddForeignKey("dbo.Files", "folderID", "dbo.Folders", "ID", cascadeDelete: true);
        }
    }
}

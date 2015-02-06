namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class folderSON : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "Folder_ID", "dbo.Folders");
            DropIndex("dbo.Files", new[] { "Folder_ID" });
            RenameColumn(table: "dbo.Files", name: "Folder_ID", newName: "folderID");
            AlterColumn("dbo.Files", "folderID", c => c.Int(nullable: false));
            CreateIndex("dbo.Files", "folderID");
            AddForeignKey("dbo.Files", "folderID", "dbo.Folders", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "folderID", "dbo.Folders");
            DropIndex("dbo.Files", new[] { "folderID" });
            AlterColumn("dbo.Files", "folderID", c => c.Int());
            RenameColumn(table: "dbo.Files", name: "folderID", newName: "Folder_ID");
            CreateIndex("dbo.Files", "Folder_ID");
            AddForeignKey("dbo.Files", "Folder_ID", "dbo.Folders", "ID");
        }
    }
}

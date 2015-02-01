namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "FileContent", c => c.Binary(nullable: false));
            AddColumn("dbo.Files", "MimeType", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Files", "FileName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Files", "FileDescription", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "FileDescription");
            DropColumn("dbo.Files", "FileName");
            DropColumn("dbo.Files", "MimeType");
            DropColumn("dbo.Files", "FileContent");
        }
    }
}

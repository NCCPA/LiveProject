namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.User", "LastName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.User", "DOB", c => c.DateTime());
            AddColumn("dbo.User", "Phone", c => c.Long(nullable: false));
            AddColumn("dbo.User", "PhoneExt", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Email", c => c.String(maxLength: 100));
            AddColumn("dbo.User", "Address", c => c.String(maxLength: 150));
            AddColumn("dbo.User", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "isContact", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "canUploadFile", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "canCreateMeeting", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "Position", c => c.String(maxLength: 100));
            AddColumn("dbo.User", "PositionDescription", c => c.String(maxLength: 1000));
            AddColumn("dbo.User", "RoleID", c => c.Int(nullable: false));
            CreateIndex("dbo.User", "RoleID");
            AddForeignKey("dbo.User", "RoleID", "dbo.Role", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "RoleID", "dbo.Role");
            DropIndex("dbo.User", new[] { "RoleID" });
            DropColumn("dbo.User", "RoleID");
            DropColumn("dbo.User", "PositionDescription");
            DropColumn("dbo.User", "Position");
            DropColumn("dbo.User", "canCreateMeeting");
            DropColumn("dbo.User", "canUploadFile");
            DropColumn("dbo.User", "isContact");
            DropColumn("dbo.User", "isActive");
            DropColumn("dbo.User", "Address");
            DropColumn("dbo.User", "Email");
            DropColumn("dbo.User", "PhoneExt");
            DropColumn("dbo.User", "Phone");
            DropColumn("dbo.User", "DOB");
            DropColumn("dbo.User", "LastName");
            DropColumn("dbo.User", "FirstName");
        }
    }
}

namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AspUserMerge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "DOB", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "UserPhoneExt", c => c.Int());
            AddColumn("dbo.AspNetUsers", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "isContact", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "canUploadFile", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "canCreateMeeting", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Position", c => c.String(maxLength: 100));
            AddColumn("dbo.AspNetUsers", "PositionDescription", c => c.String(maxLength: 1000));
            AddColumn("dbo.AspNetUsers", "RoleID", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "FName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.AspNetUsers", "RoleID");
            //AddForeignKey("dbo.AspNetUsers", "RoleID", "dbo.Roles", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "RoleID", "dbo.Roles");
            DropIndex("dbo.AspNetUsers", new[] { "RoleID" });
            AlterColumn("dbo.AspNetUsers", "FName", c => c.String());
            DropColumn("dbo.AspNetUsers", "RoleID");
            DropColumn("dbo.AspNetUsers", "PositionDescription");
            DropColumn("dbo.AspNetUsers", "Position");
            DropColumn("dbo.AspNetUsers", "canCreateMeeting");
            DropColumn("dbo.AspNetUsers", "canUploadFile");
            DropColumn("dbo.AspNetUsers", "isContact");
            DropColumn("dbo.AspNetUsers", "isActive");
            DropColumn("dbo.AspNetUsers", "UserPhoneExt");
            DropColumn("dbo.AspNetUsers", "DOB");
            DropColumn("dbo.AspNetUsers", "LName");
        }
    }
}

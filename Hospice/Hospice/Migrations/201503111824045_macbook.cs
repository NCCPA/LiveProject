namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class macbook : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubRoles", "UserSubRole_ID", "dbo.UserSubRoles");
            DropForeignKey("dbo.Users", "UserSubRole_ID", "dbo.UserSubRoles");
            DropIndex("dbo.SubRoles", new[] { "UserSubRole_ID" });
            DropIndex("dbo.Users", new[] { "UserSubRole_ID" });
            DropColumn("dbo.SubRoles", "UserSubRole_ID");
            DropColumn("dbo.Users", "UserSubRole_ID");
            DropTable("dbo.UserSubRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserSubRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        SubRoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Users", "UserSubRole_ID", c => c.Int());
            AddColumn("dbo.SubRoles", "UserSubRole_ID", c => c.Int());
            CreateIndex("dbo.Users", "UserSubRole_ID");
            CreateIndex("dbo.SubRoles", "UserSubRole_ID");
            AddForeignKey("dbo.Users", "UserSubRole_ID", "dbo.UserSubRoles", "ID");
            AddForeignKey("dbo.SubRoles", "UserSubRole_ID", "dbo.UserSubRoles", "ID");
        }
    }
}

namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class macbook11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Roles", "roleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "roleName", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Roles", "Name");
        }
    }
}

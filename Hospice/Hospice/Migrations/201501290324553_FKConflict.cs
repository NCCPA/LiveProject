namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKConflict : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "FName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "FName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}

namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unknownModelChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Phone", c => c.Long(nullable: false));
        }
    }
}

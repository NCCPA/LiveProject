namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFirstName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FName");
        }
    }
}

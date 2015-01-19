namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LinkHome",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LinkStaff",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LinkStaff");
            DropTable("dbo.LinkHome");
        }
    }
}

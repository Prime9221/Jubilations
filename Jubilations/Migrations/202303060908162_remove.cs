namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aboutus",
                c => new
                    {
                        aboutId = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.aboutId);
            
           
            
        }
        
        public override void Down()
        {
            
            DropTable("dbo.Aboutus");
        }
    }
}

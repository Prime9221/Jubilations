namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rlogin : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Logins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        rolls = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}

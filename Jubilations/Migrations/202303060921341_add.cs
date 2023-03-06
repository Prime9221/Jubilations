namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aboutus", "Pictures", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aboutus", "Pictures");
        }
    }
}

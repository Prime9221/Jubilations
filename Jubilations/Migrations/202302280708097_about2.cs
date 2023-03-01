namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class about2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aboutus", "Slogan1", c => c.String());
            AddColumn("dbo.Aboutus", "Slogan2", c => c.String());
            AddColumn("dbo.Aboutus", "Slogan3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aboutus", "Slogan3");
            DropColumn("dbo.Aboutus", "Slogan2");
            DropColumn("dbo.Aboutus", "Slogan1");
        }
    }
}

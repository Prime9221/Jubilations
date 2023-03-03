namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editor : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Aboutus", "Slogan1");
            DropColumn("dbo.Aboutus", "Slogan2");
            DropColumn("dbo.Aboutus", "Slogan3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aboutus", "Slogan3", c => c.String());
            AddColumn("dbo.Aboutus", "Slogan2", c => c.String());
            AddColumn("dbo.Aboutus", "Slogan1", c => c.String());
        }
    }
}

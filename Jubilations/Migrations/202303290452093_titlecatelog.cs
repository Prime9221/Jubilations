namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class titlecatelog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vender_Catalog", "title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vender_Catalog", "title");
        }
    }
}

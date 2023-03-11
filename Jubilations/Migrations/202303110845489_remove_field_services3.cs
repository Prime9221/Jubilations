namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_field_services3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "Services_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Services_Name", c => c.String());
        }
    }
}

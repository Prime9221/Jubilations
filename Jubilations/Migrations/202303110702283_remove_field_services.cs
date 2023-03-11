namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_field_services : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "Services_Image");
            DropColumn("dbo.Services", "Services_Budget");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Services_Budget", c => c.String());
            AddColumn("dbo.Services", "Services_Image", c => c.String());
        }
    }
}

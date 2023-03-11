namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_field_services2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Services_Status", c => c.String());
            DropColumn("dbo.Services", "Services_StatusO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Services_StatusO", c => c.String());
            DropColumn("dbo.Services", "Services_Status");
        }
    }
}

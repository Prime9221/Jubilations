namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_field_services21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vender_Catalog", "Description", c => c.String());
            AddColumn("dbo.Vender_Catalog", "Price", c => c.String());
            AddColumn("dbo.Vender_Catalog", "Status", c => c.String());
            AddColumn("dbo.Vender_Catalog", "Create_Date", c => c.String());
            AddColumn("dbo.Vender_Catalog", "Update_Date", c => c.String());
            DropColumn("dbo.Services", "Services_Description");
            DropColumn("dbo.Services", "Services_Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Services_Status", c => c.String());
            AddColumn("dbo.Services", "Services_Description", c => c.String());
            DropColumn("dbo.Vender_Catalog", "Update_Date");
            DropColumn("dbo.Vender_Catalog", "Create_Date");
            DropColumn("dbo.Vender_Catalog", "Status");
            DropColumn("dbo.Vender_Catalog", "Price");
            DropColumn("dbo.Vender_Catalog", "Description");
        }
    }
}

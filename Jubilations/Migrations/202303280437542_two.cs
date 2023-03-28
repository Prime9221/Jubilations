namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vender_Catalog", "Product_image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vender_Catalog", "Product_image");
        }
    }
}

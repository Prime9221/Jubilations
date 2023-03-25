namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vender_Catalog", "Product_image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vender_Catalog", "Product_image", c => c.String());
        }
    }
}

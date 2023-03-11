namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Users", "Services_Id", "dbo.Services");
            DropIndex("dbo.Users", new[] { "Services_Id" });
            DropIndex("dbo.Users", new[] { "Category_Id" });
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropColumn("dbo.Users", "Services_Id");
            DropColumn("dbo.Users", "Services_Name");
            DropColumn("dbo.Users", "Category_Id");
            DropColumn("dbo.Users", "City_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "City_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Category_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Services_Name", c => c.String());
            AddColumn("dbo.Users", "Services_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "City_Id");
            CreateIndex("dbo.Users", "Category_Id");
            CreateIndex("dbo.Users", "Services_Id");
            AddForeignKey("dbo.Users", "Services_Id", "dbo.Services", "Services_Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "City_Id", "dbo.Cities", "City_Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "Category_Id", "dbo.Categories", "Category_Id", cascadeDelete: true);
        }
    }
}

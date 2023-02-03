namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Blog_Id = c.Int(nullable: false, identity: true),
                        Blog_Name = c.String(),
                        Blog_Title = c.String(),
                        Blog_Description = c.String(),
                        Blog_Image = c.String(),
                        Blog_Create_Date = c.String(),
                        Blog_Update_Date = c.String(),
                    })
                .PrimaryKey(t => t.Blog_Id);
            
            CreateTable(
                "dbo.Blog_Comment",
                c => new
                    {
                        Blog_Comment_Id = c.Int(nullable: false, identity: true),
                        Blog_Comment_Name = c.String(),
                        Blog_Comment_Comment = c.String(),
                    })
                .PrimaryKey(t => t.Blog_Comment_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Category_Id = c.Int(nullable: false, identity: true),
                        Category_Name = c.String(),
                        Category_Status = c.String(),
                        Category_Create_Date = c.String(),
                        Category_Update_Date = c.String(),
                    })
                .PrimaryKey(t => t.Category_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        City_Id = c.Int(nullable: false, identity: true),
                        City_Name = c.String(),
                    })
                .PrimaryKey(t => t.City_Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Contact_Id = c.Int(nullable: false, identity: true),
                        Contact_Name = c.String(),
                        Contact_Email = c.String(),
                        Contact_PhoneNo = c.String(),
                        City_Id = c.Int(nullable: false),
                        Contact_Message = c.String(),
                    })
                .PrimaryKey(t => t.Contact_Id)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: false)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Service_Role",
                c => new
                    {
                        Service_Role_Id = c.Int(nullable: false, identity: true),
                        Service_Role_Name = c.String(),
                    })
                .PrimaryKey(t => t.Service_Role_Id);
            
            CreateTable(
                "dbo.Service_Role_Map",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Services_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: false)
                .ForeignKey("dbo.Services", t => t.Services_Id, cascadeDelete: false)
                .Index(t => t.Services_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Services_Id = c.Int(nullable: false, identity: true),
                        Services_Name = c.String(),
                        User_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        Services_Title = c.String(),
                        Services_Description = c.String(),
                        Services_Image = c.String(),
                        Services_Budget = c.String(),
                        Services_StatusO = c.String(),
                        Services_Create_Date = c.String(),
                        Services_Update_Date = c.String(),
                    })
                .PrimaryKey(t => t.Services_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        User_Id = c.Int(nullable: false, identity: true),
                        User_Name = c.String(),
                        User_Email = c.String(),
                        User_PhoneNo = c.String(),
                        User_DOB = c.String(),
                        User_Profile_Image = c.String(),
                        Services_Id = c.Int(nullable: false),
                        Services_Name = c.String(),
                        Category_Id = c.Int(nullable: false),
                        City_Id = c.Int(nullable: false),
                        User_GSTNO = c.String(),
                        User_ShopName = c.String(),
                        User_Address = c.String(),
                        User_PinCode = c.String(),
                        User_Password = c.String(),
                        User_Create_Date = c.String(),
                        User_Update_Date = c.String(),
                    })
                .PrimaryKey(t => t.User_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: false)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: false)
                .ForeignKey("dbo.Services", t => t.Services_Id, cascadeDelete: false)
                .Index(t => t.Services_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.SuccessStories",
                c => new
                    {
                        SuccessStory_Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        SuccessStory_Rating = c.String(),
                        SuccessStory_Message = c.String(),
                        SuccessStory_Create_Date = c.String(),
                        SuccessStory_Update_Date = c.String(),
                    })
                .PrimaryKey(t => t.SuccessStory_Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.User_Role",
                c => new
                    {
                        UserRole_Id = c.Int(nullable: false, identity: true),
                        UserRole_Name = c.String(),
                    })
                .PrimaryKey(t => t.UserRole_Id);
            
            CreateTable(
                "dbo.User_Role_Map",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        UserRole_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: false)
                .ForeignKey("dbo.User_Role", t => t.UserRole_Id, cascadeDelete: false)
                .Index(t => t.User_Id)
                .Index(t => t.UserRole_Id);
            
            CreateTable(
                "dbo.Vender_Catalog",
                c => new
                    {
                        Catalog_Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        Services_Id = c.Int(nullable: false),
                        Product_image = c.String(),
                    })
                .PrimaryKey(t => t.Catalog_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: false)
                .ForeignKey("dbo.Services", t => t.Services_Id, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Services_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vender_Catalog", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Vender_Catalog", "Services_Id", "dbo.Services");
            DropForeignKey("dbo.Vender_Catalog", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.User_Role_Map", "UserRole_Id", "dbo.User_Role");
            DropForeignKey("dbo.User_Role_Map", "User_Id", "dbo.Users");
            DropForeignKey("dbo.SuccessStories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Service_Role_Map", "Services_Id", "dbo.Services");
            DropForeignKey("dbo.Services", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Services_Id", "dbo.Services");
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Users", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Services", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Service_Role_Map", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Contacts", "City_Id", "dbo.Cities");
            DropIndex("dbo.Vender_Catalog", new[] { "Services_Id" });
            DropIndex("dbo.Vender_Catalog", new[] { "Category_Id" });
            DropIndex("dbo.Vender_Catalog", new[] { "User_Id" });
            DropIndex("dbo.User_Role_Map", new[] { "UserRole_Id" });
            DropIndex("dbo.User_Role_Map", new[] { "User_Id" });
            DropIndex("dbo.SuccessStories", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropIndex("dbo.Users", new[] { "Category_Id" });
            DropIndex("dbo.Users", new[] { "Services_Id" });
            DropIndex("dbo.Services", new[] { "Category_Id" });
            DropIndex("dbo.Services", new[] { "User_Id" });
            DropIndex("dbo.Service_Role_Map", new[] { "Category_Id" });
            DropIndex("dbo.Service_Role_Map", new[] { "Services_Id" });
            DropIndex("dbo.Contacts", new[] { "City_Id" });
            DropTable("dbo.Vender_Catalog");
            DropTable("dbo.User_Role_Map");
            DropTable("dbo.User_Role");
            DropTable("dbo.SuccessStories");
            DropTable("dbo.Users");
            DropTable("dbo.Services");
            DropTable("dbo.Service_Role_Map");
            DropTable("dbo.Service_Role");
            DropTable("dbo.Contacts");
            DropTable("dbo.Cities");
            DropTable("dbo.Categories");
            DropTable("dbo.Blog_Comment");
            DropTable("dbo.Blogs");
        }
    }
}

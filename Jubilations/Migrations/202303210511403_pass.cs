namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User_Role_Map", "User_Passwords_User_Id", c => c.Int());
            CreateIndex("dbo.User_Role_Map", "User_Passwords_User_Id");
            AddForeignKey("dbo.User_Role_Map", "User_Passwords_User_Id", "dbo.Users", "User_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Role_Map", "User_Passwords_User_Id", "dbo.Users");
            DropIndex("dbo.User_Role_Map", new[] { "User_Passwords_User_Id" });
            DropColumn("dbo.User_Role_Map", "User_Passwords_User_Id");
        }
    }
}

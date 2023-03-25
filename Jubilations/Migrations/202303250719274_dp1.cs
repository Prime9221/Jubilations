namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dp1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImagePath", c => c.String());
            DropColumn("dbo.Users", "User_Profile_Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "User_Profile_Image", c => c.String());
            DropColumn("dbo.Users", "ImagePath");
        }
    }
}

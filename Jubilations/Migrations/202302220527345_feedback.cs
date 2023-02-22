namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feedback : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuccessStories", "SuccessStory_Images", c => c.String());
            DropColumn("dbo.SuccessStories", "SuccessStory_Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SuccessStories", "SuccessStory_Rating", c => c.String());
            DropColumn("dbo.SuccessStories", "SuccessStory_Images");
        }
    }
}

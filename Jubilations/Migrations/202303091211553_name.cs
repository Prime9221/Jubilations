namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FeedBacks", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FeedBacks", "Name");
        }
    }
}

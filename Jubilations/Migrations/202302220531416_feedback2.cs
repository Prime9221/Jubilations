namespace Jubilations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feedback2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        FeedBack_Id = c.Int(nullable: false, identity: true),
                        FeedBack_Email = c.String(),
                        FeedBack_Message = c.String(),
                        SuccessStory_Create_Date = c.String(),
                        SuccessStory_Update_Date = c.String(),
                    })
                .PrimaryKey(t => t.FeedBack_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FeedBacks");
        }
    }
}

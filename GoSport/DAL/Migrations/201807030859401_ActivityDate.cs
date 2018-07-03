namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActivityDate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BinaryImage = c.Binary(),
                        Activity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Activity_Id)
                .Index(t => t.Activity_Id);
            
            AddColumn("dbo.Activities", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Activity_Id", "dbo.Activities");
            DropIndex("dbo.Images", new[] { "Activity_Id" });
            DropColumn("dbo.Activities", "Date");
            DropTable("dbo.Images");
        }
    }
}

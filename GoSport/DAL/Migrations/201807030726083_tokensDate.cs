namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tokensDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tokens", "Date");
        }
    }
}

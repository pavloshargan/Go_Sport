namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgr2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnconfirmedUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Firstname = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ConfirmEmails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ConfirmEmails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.UnconfirmedUsers");
        }
    }
}

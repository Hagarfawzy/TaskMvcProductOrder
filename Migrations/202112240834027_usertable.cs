namespace TaskMvcProductOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Orders", "User_UserId", c => c.Int());
            AddColumn("dbo.Products", "User_UserId", c => c.Int());
            CreateIndex("dbo.Orders", "User_UserId");
            CreateIndex("dbo.Products", "User_UserId");
            AddForeignKey("dbo.Orders", "User_UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.Products", "User_UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "User_UserId", "dbo.Users");
            DropIndex("dbo.Products", new[] { "User_UserId" });
            DropIndex("dbo.Orders", new[] { "User_UserId" });
            DropColumn("dbo.Products", "User_UserId");
            DropColumn("dbo.Orders", "User_UserId");
            DropTable("dbo.Users");
        }
    }
}

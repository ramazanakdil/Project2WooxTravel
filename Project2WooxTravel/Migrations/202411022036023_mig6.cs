namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartId = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        CartNumber = c.Int(nullable: false),
                        NameSurname = c.Int(nullable: false),
                        ExpDate = c.Int(nullable: false),
                        Ccv = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CartId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carts");
        }
    }
}

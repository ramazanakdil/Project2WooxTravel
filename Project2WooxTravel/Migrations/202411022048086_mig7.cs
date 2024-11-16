namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carts", "CartNumber", c => c.String());
            AlterColumn("dbo.Carts", "NameSurname", c => c.String());
            AlterColumn("dbo.Carts", "ExpDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carts", "ExpDate", c => c.Int(nullable: false));
            AlterColumn("dbo.Carts", "NameSurname", c => c.Int(nullable: false));
            AlterColumn("dbo.Carts", "CartNumber", c => c.Int(nullable: false));
        }
    }
}

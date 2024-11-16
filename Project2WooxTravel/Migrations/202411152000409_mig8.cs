﻿namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "ReservationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "ReservationDate", c => c.DateTime(nullable: false));
        }
    }
}
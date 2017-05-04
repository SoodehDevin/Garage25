namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewsDuration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "ParkingDuration", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "ParkingDuration");
        }
    }
}

namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewsWithout : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vehicles", "ParkingDuration");
            DropColumn("dbo.Vehicles", "ParkingCost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "ParkingCost", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "ParkingDuration", c => c.Double(nullable: false));
        }
    }
}

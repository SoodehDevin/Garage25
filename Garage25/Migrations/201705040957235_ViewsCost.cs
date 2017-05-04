namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewsCost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "ParkingCost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "ParkingCost");
        }
    }
}

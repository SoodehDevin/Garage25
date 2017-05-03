namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedReady : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Make", c => c.String());
            DropColumn("dbo.Vehicles", "Brand");
            DropColumn("dbo.Vehicles", "WheelTally");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "WheelTally", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "Brand", c => c.String());
            DropColumn("dbo.Vehicles", "Make");
        }
    }
}

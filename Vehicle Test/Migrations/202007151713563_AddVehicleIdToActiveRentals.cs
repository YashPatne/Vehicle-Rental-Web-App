namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVehicleIdToActiveRentals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "VehicleId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActiveRentals", "VehicleId");
        }
    }
}

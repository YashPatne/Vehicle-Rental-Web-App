namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVehicleTypeIdToActiveRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "VehicleTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActiveRentals", "VehicleTypeId");
        }
    }
}

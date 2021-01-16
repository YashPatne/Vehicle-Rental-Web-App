namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeVehicleIsAvailableInAnotherAction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "VehicleNumber", c => c.String());
            AddColumn("dbo.ActiveRentals", "VehicleName", c => c.String());
            AddColumn("dbo.ActiveRentals", "VehicleTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActiveRentals", "VehicleTypeId");
            DropColumn("dbo.ActiveRentals", "VehicleName");
            DropColumn("dbo.ActiveRentals", "VehicleNumber");
        }
    }
}

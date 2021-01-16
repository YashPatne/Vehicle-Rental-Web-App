namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeVehicleTypeNameToVehicleNameInActiveRentals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "VehicleName", c => c.String());
            DropColumn("dbo.ActiveRentals", "VehicleTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActiveRentals", "VehicleTypeName", c => c.String());
            DropColumn("dbo.ActiveRentals", "VehicleName");
        }
    }
}

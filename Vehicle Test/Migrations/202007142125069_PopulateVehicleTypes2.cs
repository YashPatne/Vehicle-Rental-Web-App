namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicleTypes2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('Scooter',50)");
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('Bike',70)");
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('Car',200)");
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('MiniBus',500)");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicleType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('Bicycle',20)");
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('Scooter',50)");
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('Car',200)");
            Sql("INSERT INTO VehicleTypes(VehicleTypeName, HourlyRate) VALUES('ATV',150)");
        }
        
        public override void Down()
        {
        }
    }
}

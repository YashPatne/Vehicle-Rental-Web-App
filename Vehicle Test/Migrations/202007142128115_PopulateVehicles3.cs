namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicles3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId) VALUES('NTorque','MH31DC2018',1)");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId) VALUES('Active','MH31AC1117',1)");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId) VALUES('IMpulse','MH31XY0007',2)");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId) VALUES('Ertiga','MH31FG2018',3)");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId) VALUES('Tata Winger','MH31QW9087',4)");
        }
        
        public override void Down()
        {
        }
    }
}

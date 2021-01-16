namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicles41 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId,IsAvailable) VALUES('NTorque','MH31DC2018',1,'True')");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId,IsAvailable) VALUES('Active','MH31AC1117',1,'True')");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId,IsAvailable) VALUES('IMpulse','MH31XY0007',2,'True')");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId,IsAvailable) VALUES('Ertiga','MH31FG2018',3,'True')");
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId,IsAvailable) VALUES('Tata Winger','MH31QW9087',4,'True')");
        }
        
        public override void Down()
        {
        }
    }
}

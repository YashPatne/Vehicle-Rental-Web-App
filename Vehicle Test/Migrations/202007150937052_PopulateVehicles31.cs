namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicles31 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId,IsAvailable) VALUES('NTorque','MH31DC2018',1,'True')");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Vehicles(Name,Number,VehicleTypeId) VALUES('Innova','MH31DC2018',1)");
        }
        
        public override void Down()
        {
        }
    }
}

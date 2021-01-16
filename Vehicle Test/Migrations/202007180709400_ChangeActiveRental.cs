namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeActiveRental : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ActiveRentals", "VehicleNumber");
            DropColumn("dbo.ActiveRentals", "VehicleName");
            DropColumn("dbo.ActiveRentals", "VehicleTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActiveRentals", "VehicleTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.ActiveRentals", "VehicleName", c => c.String());
            AddColumn("dbo.ActiveRentals", "VehicleNumber", c => c.String());
        }
    }
}

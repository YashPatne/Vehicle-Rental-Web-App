namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateActiveRentals : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ActiveRentals", "VehicleNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActiveRentals", "VehicleNumber", c => c.String());
        }
    }
}

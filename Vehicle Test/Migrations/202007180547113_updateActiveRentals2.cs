namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateActiveRentals2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "VehicleNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActiveRentals", "VehicleNumber");
        }
    }
}

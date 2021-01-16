namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsAvailableToVehicleBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "IsAvailable", c => c.Int(nullable: false));
        }
    }
}

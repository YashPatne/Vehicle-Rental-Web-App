namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsAvailableToVehicles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "IsAvailable");
        }
    }
}

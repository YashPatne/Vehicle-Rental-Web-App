namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnoteVehicle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Number", c => c.String());
            AlterColumn("dbo.Vehicles", "Name", c => c.String());
        }
    }
}

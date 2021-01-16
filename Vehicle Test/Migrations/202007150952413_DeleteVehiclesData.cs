namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteVehiclesData : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Vehicles");
        }
        
        public override void Down()
        {
        }
    }
}

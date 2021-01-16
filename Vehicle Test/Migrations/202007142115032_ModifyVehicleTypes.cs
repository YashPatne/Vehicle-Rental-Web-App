namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyVehicleTypes : DbMigration
    {
        public override void Up()
        {

            Sql("DELETE FROM VehicleTypes WHERE Id IN (1,4)");
          
        }
        
        public override void Down()
        {
        }
    }
}

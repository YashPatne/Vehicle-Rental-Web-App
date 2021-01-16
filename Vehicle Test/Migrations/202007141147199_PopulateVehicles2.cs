namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicles2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE  FROM Vehicles WHERE Id=1");
           
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClearActiveRentals : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM ActiveRentals");
        }
        
        public override void Down()
        {
        }
    }
}

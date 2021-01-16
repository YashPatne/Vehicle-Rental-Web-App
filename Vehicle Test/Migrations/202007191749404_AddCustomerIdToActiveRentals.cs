namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerIdToActiveRentals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "CustomerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActiveRentals", "CustomerId");
        }
    }
}

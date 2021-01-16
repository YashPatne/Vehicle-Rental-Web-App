namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActiveToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsActive");
        }
    }
}

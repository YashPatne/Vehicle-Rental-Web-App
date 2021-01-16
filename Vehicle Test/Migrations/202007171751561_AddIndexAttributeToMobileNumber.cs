namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndexAttributeToMobileNumber : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Customers", "MobileNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MobileNumber" });
        }
    }
}

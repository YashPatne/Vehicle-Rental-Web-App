namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndexToLicenseNumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Customers", "LicenseNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "LicenseNumber" });
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false, maxLength: 255));
        }
    }
}

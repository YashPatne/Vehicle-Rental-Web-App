namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertChanges : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "LicenseNumber" });
            DropIndex("dbo.Customers", new[] { "MobileNumber" });
            DropIndex("dbo.Vehicles", new[] { "Number" });
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Vehicles", "Number", unique: true);
            CreateIndex("dbo.Customers", "MobileNumber", unique: true);
            CreateIndex("dbo.Customers", "LicenseNumber", unique: true);
        }
    }
}

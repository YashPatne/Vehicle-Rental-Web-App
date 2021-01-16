namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RedoChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Customers", "LicenseNumber", unique: true);
            CreateIndex("dbo.Customers", "MobileNumber", unique: true);
            CreateIndex("dbo.Vehicles", "Number", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vehicles", new[] { "Number" });
            DropIndex("dbo.Customers", new[] { "MobileNumber" });
            DropIndex("dbo.Customers", new[] { "LicenseNumber" });
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false));
        }
    }
}

namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeMobileNumberLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MobileNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MobileNumber", c => c.Int(nullable: false));
        }
    }
}

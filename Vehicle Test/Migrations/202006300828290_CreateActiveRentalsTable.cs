namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateActiveRentalsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActiveRentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        IssueDate = c.DateTime(nullable: false),
                        VehicleNumber = c.String(),
                        VehicleTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ActiveRentals");
        }
    }
}

namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateWorkVehiclesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.String(),
                        VehicleTypeId = c.Int(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleTypeId, cascadeDelete: true)
                .Index(t => t.VehicleTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkVehicles", "VehicleTypeId", "dbo.VehicleTypes");
            DropIndex("dbo.WorkVehicles", new[] { "VehicleTypeId" });
            DropTable("dbo.WorkVehicles");
        }
    }
}

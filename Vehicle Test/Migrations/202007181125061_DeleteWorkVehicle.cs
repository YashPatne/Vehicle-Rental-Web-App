namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteWorkVehicle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WorkVehicles", "VehicleTypeId", "dbo.VehicleTypes");
            DropIndex("dbo.WorkVehicles", new[] { "VehicleTypeId" });
            DropTable("dbo.WorkVehicles");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.WorkVehicles", "VehicleTypeId");
            AddForeignKey("dbo.WorkVehicles", "VehicleTypeId", "dbo.VehicleTypes", "Id", cascadeDelete: true);
        }
    }
}

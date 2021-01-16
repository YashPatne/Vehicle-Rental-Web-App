namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderToCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "GenderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Customers", "GenderId");
            AddForeignKey("dbo.Customers", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "GenderId", "dbo.Genders");
            DropIndex("dbo.Customers", new[] { "GenderId" });
            AlterColumn("dbo.Customers", "LicenseNumber", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "GenderId");
            DropTable("dbo.Genders");
        }
    }
}

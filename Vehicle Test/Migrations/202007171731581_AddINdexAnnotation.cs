namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddINdexAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Vehicles", "Number", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vehicles", new[] { "Number" });
            AlterColumn("dbo.Vehicles", "Number", c => c.String(nullable: false, maxLength: 255));
        }
    }
}

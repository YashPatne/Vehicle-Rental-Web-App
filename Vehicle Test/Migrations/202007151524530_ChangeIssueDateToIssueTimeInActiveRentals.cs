namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIssueDateToIssueTimeInActiveRentals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveRentals", "IssueTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.ActiveRentals", "IssueDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActiveRentals", "IssueDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.ActiveRentals", "IssueTime");
        }
    }
}

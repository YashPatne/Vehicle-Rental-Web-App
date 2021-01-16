namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name,BirthDate,LicenseNumber,MobileNumber,GenderId) VALUES('Suresh Kumar','Jan 1 2000','MH31200010201',9876543210,1)");
           

        }

        public override void Down()
        {
        }
    }
}

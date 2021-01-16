namespace Vehicle_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenders : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders(Name) VALUES('MALE')");
            Sql("INSERT INTO Genders(Name) VALUES('FEMALE')");
            Sql("INSERT INTO Genders(Name) VALUES('OTHERS')");
        }
        
        public override void Down()
        {
        }
    }
}

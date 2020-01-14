namespace RentalCarCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (1, 'Compact')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (2, 'Economy')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (3, 'Full Size')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (4, 'Family SUV')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (5, 'MiniVan')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (6, 'Luxury')");
        }
        public override void Down()
        {
        }
    }
}

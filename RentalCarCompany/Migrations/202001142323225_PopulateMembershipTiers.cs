namespace RentalCarCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTiers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTiers (Id, Tier, DiscountRate) VALUES (1, 'Bronze', 5)");
            Sql("INSERT INTO MembershipTiers (Id, Tier, DiscountRate) VALUES (2, 'Silver', 5)");
            Sql("INSERT INTO MembershipTiers (Id, Tier, DiscountRate) VALUES (3, 'Gold', 5)");
        }
        
        public override void Down()
        {
        }
    }
}

namespace RentalCarCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedMembershipTierModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTiers", "DiscountRate", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTiers", "DiscountRate");
        }
    }
}

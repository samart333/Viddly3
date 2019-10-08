namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeIdToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "MembershipTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "MembershipTypeId");
        }
    }
}

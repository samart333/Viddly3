namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMembershipTypeId : DbMigration
    {
        public override void Up()
        {
            RenameColumn("Members", "MembershipType_Id", "MembershipTypeId");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipType_IdCleanUp : DbMigration
    {
        public override void Up()
        {

            DropColumn("Members", "MembershipTypeId");
        }
        
        public override void Down()
        {
        }
    }
}

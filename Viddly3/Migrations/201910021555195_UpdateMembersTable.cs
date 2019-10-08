namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembersTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Members SET MembershipTypeId = 3 WHERE Name = 'Hally'");

        }
        
        public override void Down()
        {
        }
    }
}

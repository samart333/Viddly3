namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembersRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Members SET MembershipTypeId = 2 WHERE Name = 'Carlos Gonzales'");
            Sql("UPDATE Members SET MembershipTypeId = 3 WHERE Name = 'Robert Contreras'");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembersTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Members SET Name = 'Rodri' WHERE Id = 4");

        }
        
        public override void Down()
        {
        }
    }
}

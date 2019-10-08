namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "BirthDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "BirthDate");
        }
    }
}

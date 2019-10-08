namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}

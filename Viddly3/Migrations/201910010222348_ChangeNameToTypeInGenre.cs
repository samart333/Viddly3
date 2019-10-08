namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameToTypeInGenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Type", c => c.String());
            DropColumn("dbo.Genres", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Genres", "Type");
        }
    }
}

namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "IsSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "IsSubscribed");
        }
    }
}

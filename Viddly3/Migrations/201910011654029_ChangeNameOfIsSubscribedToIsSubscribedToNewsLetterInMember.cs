namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameOfIsSubscribedToIsSubscribedToNewsLetterInMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "IsSubscribed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "IsSubscribed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "IsSubscribedToNewsLetter");
        }
    }
}

namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "MembershipType_Id", c => c.Byte());
            CreateIndex("dbo.Members", "MembershipType_Id");
            AddForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id" });
            DropColumn("dbo.Members", "MembershipType_Id");
        }
    }
}

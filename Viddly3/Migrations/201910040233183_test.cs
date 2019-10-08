namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id" });
            DropTable("dbo.Members");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(),
                        Age = c.Int(nullable: false),
                        Sex = c.String(),
                        Company = c.String(),
                        IsSubscribedToNewsLetter = c.Boolean(nullable: false),
                        MembershipTypeId = c.Int(nullable: false),
                        MembershipType_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Members", "MembershipType_Id");
            AddForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}

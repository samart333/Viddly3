namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
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
                        MembershipType_Id = c.Byte(nullable: false),
                        MembershipType_Id1 = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipType_Id1)
                .Index(t => t.MembershipType_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id1", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id1" });
            DropTable("dbo.Members");
        }
    }
}

namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedMemershipTypesDebesets : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id1", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id1" });
            DropTable("dbo.Members");
            DropTable("dbo.MembershipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        popularity = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Members", "MembershipType_Id1");
            AddForeignKey("dbo.Members", "MembershipType_Id1", "dbo.MembershipTypes", "Id");
        }
    }
}

namespace Viddly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reseteandoModels : DbMigration
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
                        MembershipTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipTypeId" });
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Members");
        }
    }
}

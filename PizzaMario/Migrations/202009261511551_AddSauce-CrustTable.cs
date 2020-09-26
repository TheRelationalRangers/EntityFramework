namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSauceCrustTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Crusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Diameter = c.Int(nullable: false),
                        Pricing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pricings", t => t.Pricing_Id)
                .Index(t => t.Pricing_Id);
            
            CreateTable(
                "dbo.Sauces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsSpicy = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Crusts", "Pricing_Id", "dbo.Pricings");
            DropIndex("dbo.Crusts", new[] { "Pricing_Id" });
            DropTable("dbo.Sauces");
            DropTable("dbo.Crusts");
        }
    }
}

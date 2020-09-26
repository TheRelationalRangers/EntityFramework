namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddIngredientPricingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    IsSpicy = c.Boolean(nullable: false),
                    IsVegy = c.Boolean(nullable: false),
                    Pricing_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pricings", t => t.Pricing_Id)
                .Index(t => t.Pricing_Id);

            CreateTable(
                "dbo.Pricings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                    StartDate = c.DateTime(nullable: false),
                    EndDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "Pricing_Id", "dbo.Pricings");
            DropIndex("dbo.Ingredients", new[] { "Pricing_Id" });
            DropTable("dbo.Pricings");
            DropTable("dbo.Ingredients");
        }
    }
}
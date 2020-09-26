namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderProductOrderlineTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Order_Id = c.Int(),
                        Pricing_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Pricings", t => t.Pricing_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Pricing_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreNumber = c.Int(nullable: false),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comment = c.String(),
                        Customer_Id = c.Int(),
                        PaymentType_Id = c.Int(),
                        Status_Id = c.Int(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.PaymentType_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        Category_Id = c.Int(),
                        Crust_Id = c.Int(),
                        Pricing_Id = c.Int(),
                        Sauce_Id = c.Int(),
                        SubCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Crusts", t => t.Crust_Id)
                .ForeignKey("dbo.Pricings", t => t.Pricing_Id)
                .ForeignKey("dbo.Sauces", t => t.Sauce_Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategory_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Crust_Id)
                .Index(t => t.Pricing_Id)
                .Index(t => t.Sauce_Id)
                .Index(t => t.SubCategory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "SubCategory_Id", "dbo.SubCategories");
            DropForeignKey("dbo.Products", "Sauce_Id", "dbo.Sauces");
            DropForeignKey("dbo.Products", "Pricing_Id", "dbo.Pricings");
            DropForeignKey("dbo.Products", "Crust_Id", "dbo.Crusts");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.OrderLines", "Pricing_Id", "dbo.Pricings");
            DropForeignKey("dbo.OrderLines", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Orders", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Orders", "PaymentType_Id", "dbo.PaymentTypes");
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "SubCategory_Id" });
            DropIndex("dbo.Products", new[] { "Sauce_Id" });
            DropIndex("dbo.Products", new[] { "Pricing_Id" });
            DropIndex("dbo.Products", new[] { "Crust_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.Orders", new[] { "Store_Id" });
            DropIndex("dbo.Orders", new[] { "Status_Id" });
            DropIndex("dbo.Orders", new[] { "PaymentType_Id" });
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.OrderLines", new[] { "Product_Id" });
            DropIndex("dbo.OrderLines", new[] { "Pricing_Id" });
            DropIndex("dbo.OrderLines", new[] { "Order_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLines");
        }
    }
}

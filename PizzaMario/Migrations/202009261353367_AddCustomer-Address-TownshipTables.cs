namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerAddressTownshipTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        HouseNumber = c.Int(nullable: false),
                        Addition = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        SeriesIndicationStart = c.Int(nullable: false),
                        SeriesIndicationEnd = c.Int(nullable: false),
                        Township_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Townships", t => t.Township_Id)
                .Index(t => t.Township_Id);
            
            CreateTable(
                "dbo.Townships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Addition = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Mail = c.String(),
                        Password = c.String(),
                        ZipCode_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.ZipCode_Id)
                .Index(t => t.ZipCode_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ZipCode_Id", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Township_Id", "dbo.Townships");
            DropIndex("dbo.Customers", new[] { "ZipCode_Id" });
            DropIndex("dbo.Addresses", new[] { "Township_Id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Townships");
            DropTable("dbo.Addresses");
        }
    }
}

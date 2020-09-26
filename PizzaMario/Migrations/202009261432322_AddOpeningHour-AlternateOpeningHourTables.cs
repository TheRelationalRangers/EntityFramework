namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOpeningHourAlternateOpeningHourTables : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "ZipCode_Id", newName: "Address_Id");
            RenameIndex(table: "dbo.Customers", name: "IX_ZipCode_Id", newName: "IX_Address_Id");
            CreateTable(
                "dbo.AlternateOpeningHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weekday = c.Int(nullable: false),
                        OpeningTime = c.DateTime(nullable: false),
                        ClosingTime = c.DateTime(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StoreNumber = c.Int(nullable: false),
                        CountryCode = c.String(),
                        Address_Id = c.Int(),
                        DeliveryRange_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.DeliveryRanges", t => t.DeliveryRange_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.DeliveryRange_Id);
            
            CreateTable(
                "dbo.DeliveryRanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaxRange = c.String(),
                        MinRange = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OpeningHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weekday = c.Int(nullable: false),
                        OpeningTime = c.DateTime(nullable: false),
                        ClosingTime = c.DateTime(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Store_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OpeningHours", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.AlternateOpeningHours", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Stores", "DeliveryRange_Id", "dbo.DeliveryRanges");
            DropForeignKey("dbo.Stores", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.OpeningHours", new[] { "Store_Id" });
            DropIndex("dbo.Stores", new[] { "DeliveryRange_Id" });
            DropIndex("dbo.Stores", new[] { "Address_Id" });
            DropIndex("dbo.AlternateOpeningHours", new[] { "Store_Id" });
            DropTable("dbo.OpeningHours");
            DropTable("dbo.DeliveryRanges");
            DropTable("dbo.Stores");
            DropTable("dbo.AlternateOpeningHours");
            RenameIndex(table: "dbo.Customers", name: "IX_Address_Id", newName: "IX_ZipCode_Id");
            RenameColumn(table: "dbo.Customers", name: "Address_Id", newName: "ZipCode_Id");
        }
    }
}

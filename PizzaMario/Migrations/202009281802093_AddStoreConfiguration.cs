namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStoreConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AlternateOpeningHours", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Stores", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Stores", "DeliveryRange_Id", "dbo.DeliveryRanges");
            DropForeignKey("dbo.OpeningHours", "Store_Id", "dbo.Stores");
            DropIndex("dbo.AlternateOpeningHours", new[] { "Store_Id" });
            DropIndex("dbo.Stores", new[] { "Address_Id" });
            DropIndex("dbo.Stores", new[] { "DeliveryRange_Id" });
            DropIndex("dbo.OpeningHours", new[] { "Store_Id" });
            RenameColumn(table: "dbo.AlternateOpeningHours", name: "Store_Id", newName: "StoreId");
            RenameColumn(table: "dbo.Stores", name: "Address_Id", newName: "AddressId");
            RenameColumn(table: "dbo.Stores", name: "DeliveryRange_Id", newName: "DeliveryRangeId");
            RenameColumn(table: "dbo.OpeningHours", name: "Store_Id", newName: "StoreId");
            AlterColumn("dbo.AlternateOpeningHours", "StoreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Stores", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Stores", "CountryCode", c => c.String(nullable: false));
            AlterColumn("dbo.Stores", "AddressId", c => c.Int(nullable: false));
            AlterColumn("dbo.Stores", "DeliveryRangeId", c => c.Int(nullable: false));
            AlterColumn("dbo.OpeningHours", "StoreId", c => c.Int(nullable: false));
            CreateIndex("dbo.AlternateOpeningHours", "StoreId");
            CreateIndex("dbo.Stores", "AddressId");
            CreateIndex("dbo.Stores", "DeliveryRangeId");
            CreateIndex("dbo.OpeningHours", "StoreId");
            AddForeignKey("dbo.AlternateOpeningHours", "StoreId", "dbo.Stores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Stores", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Stores", "DeliveryRangeId", "dbo.DeliveryRanges", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OpeningHours", "StoreId", "dbo.Stores", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OpeningHours", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Stores", "DeliveryRangeId", "dbo.DeliveryRanges");
            DropForeignKey("dbo.Stores", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.AlternateOpeningHours", "StoreId", "dbo.Stores");
            DropIndex("dbo.OpeningHours", new[] { "StoreId" });
            DropIndex("dbo.Stores", new[] { "DeliveryRangeId" });
            DropIndex("dbo.Stores", new[] { "AddressId" });
            DropIndex("dbo.AlternateOpeningHours", new[] { "StoreId" });
            AlterColumn("dbo.OpeningHours", "StoreId", c => c.Int());
            AlterColumn("dbo.Stores", "DeliveryRangeId", c => c.Int());
            AlterColumn("dbo.Stores", "AddressId", c => c.Int());
            AlterColumn("dbo.Stores", "CountryCode", c => c.String());
            AlterColumn("dbo.Stores", "Name", c => c.String());
            AlterColumn("dbo.AlternateOpeningHours", "StoreId", c => c.Int());
            RenameColumn(table: "dbo.OpeningHours", name: "StoreId", newName: "Store_Id");
            RenameColumn(table: "dbo.Stores", name: "DeliveryRangeId", newName: "DeliveryRange_Id");
            RenameColumn(table: "dbo.Stores", name: "AddressId", newName: "Address_Id");
            RenameColumn(table: "dbo.AlternateOpeningHours", name: "StoreId", newName: "Store_Id");
            CreateIndex("dbo.OpeningHours", "Store_Id");
            CreateIndex("dbo.Stores", "DeliveryRange_Id");
            CreateIndex("dbo.Stores", "Address_Id");
            CreateIndex("dbo.AlternateOpeningHours", "Store_Id");
            AddForeignKey("dbo.OpeningHours", "Store_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Stores", "DeliveryRange_Id", "dbo.DeliveryRanges", "Id");
            AddForeignKey("dbo.Stores", "Address_Id", "dbo.Addresses", "Id");
            AddForeignKey("dbo.AlternateOpeningHours", "Store_Id", "dbo.Stores", "Id");
        }
    }
}

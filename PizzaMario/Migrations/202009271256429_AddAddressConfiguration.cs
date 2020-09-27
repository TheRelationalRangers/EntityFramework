namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "Township_Id", "dbo.Townships");
            DropIndex("dbo.Addresses", new[] { "Township_Id" });
            RenameColumn(table: "dbo.Addresses", name: "Township_Id", newName: "TownshipId");
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Addresses", "HouseNumber", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Addresses", "Addition", c => c.String(maxLength: 10));
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false, maxLength: 85));
            AlterColumn("dbo.Addresses", "TownshipId", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "TownshipId");
            AddForeignKey("dbo.Addresses", "TownshipId", "dbo.Townships", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "TownshipId", "dbo.Townships");
            DropIndex("dbo.Addresses", new[] { "TownshipId" });
            AlterColumn("dbo.Addresses", "TownshipId", c => c.Int());
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String());
            AlterColumn("dbo.Addresses", "Addition", c => c.String());
            AlterColumn("dbo.Addresses", "HouseNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "Street", c => c.String());
            RenameColumn(table: "dbo.Addresses", name: "TownshipId", newName: "Township_Id");
            CreateIndex("dbo.Addresses", "Township_Id");
            AddForeignKey("dbo.Addresses", "Township_Id", "dbo.Townships", "Id");
        }
    }
}

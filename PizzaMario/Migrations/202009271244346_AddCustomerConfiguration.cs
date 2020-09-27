namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            RenameColumn(table: "dbo.Customers", name: "Address_Id", newName: "AddressId");
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Customers", "Addition", c => c.String(maxLength: 10));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Customers", "Mail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Password", c => c.String(maxLength: 25));
            AlterColumn("dbo.Customers", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "AddressId");
            AddForeignKey("dbo.Customers", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "AddressId" });
            AlterColumn("dbo.Customers", "AddressId", c => c.Int());
            AlterColumn("dbo.Customers", "Password", c => c.String());
            AlterColumn("dbo.Customers", "Mail", c => c.String());
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "Addition", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            RenameColumn(table: "dbo.Customers", name: "AddressId", newName: "Address_Id");
            CreateIndex("dbo.Customers", "Address_Id");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}

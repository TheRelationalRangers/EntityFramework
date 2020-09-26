namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusPaymentTypeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.PaymentTypes");
        }
    }
}

namespace PizzaMario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTownshipConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Townships", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Townships", "Name", c => c.String());
        }
    }
}

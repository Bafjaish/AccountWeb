namespace AccountWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountModels",
                c => new
                    {
                        AccountNumber = c.String(nullable: false, maxLength: 128),
                        AccountHolder = c.String(),
                        CurrentBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BankName = c.String(),
                        OpeningDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AccountNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountModels");
        }
    }
}

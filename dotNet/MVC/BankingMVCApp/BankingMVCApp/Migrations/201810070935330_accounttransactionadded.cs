namespace BankingMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accounttransactionadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        AccountNo = c.Int(nullable: false),
                        Name = c.String(),
                        Balance = c.Double(nullable: false),
                        Password = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountNo);
            
            CreateTable(
                "dbo.BankTransactions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TransactionType = c.String(),
                        Amount = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        Account_AccountNo = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BankAccounts", t => t.Account_AccountNo)
                .Index(t => t.Account_AccountNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BankTransactions", "Account_AccountNo", "dbo.BankAccounts");
            DropIndex("dbo.BankTransactions", new[] { "Account_AccountNo" });
            DropTable("dbo.BankTransactions");
            DropTable("dbo.BankAccounts");
        }
    }
}

namespace BankAppApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accounttransactionadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTransactions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TransactionType = c.String(),
                        TransactionAmount = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        account_AccountNo = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.account_AccountNo)
                .Index(t => t.account_AccountNo);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountNo = c.Int(nullable: false),
                        AccountHolderName = c.String(),
                        AccountBalance = c.Double(nullable: false),
                        AccountPassword = c.String(),
                        AccountCreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountTransactions", "account_AccountNo", "dbo.Accounts");
            DropIndex("dbo.AccountTransactions", new[] { "account_AccountNo" });
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountTransactions");
        }
    }
}

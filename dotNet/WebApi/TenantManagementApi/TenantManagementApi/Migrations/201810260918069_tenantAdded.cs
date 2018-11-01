namespace TenantManagementApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tenantAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Announcements",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(),
                        Captcha = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Role = c.String(),
                        Currency = c.String(),
                        ShortName = c.String(),
                        WebUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        ZipCode = c.Int(nullable: false),
                        UserDetails_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserDetails_Id)
                .Index(t => t.UserDetails_Id);
            
            CreateTable(
                "dbo.ContactDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        UserDetails_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserDetails_Id)
                .Index(t => t.UserDetails_Id);
            
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        UserSubscriptionDetails_Id = c.Guid(),
                        Master_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscriptions", t => t.UserSubscriptionDetails_Id)
                .ForeignKey("dbo.Masters", t => t.Master_Id)
                .Index(t => t.UserSubscriptionDetails_Id)
                .Index(t => t.Master_Id);
            
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        NoOfNamedUsers = c.Int(nullable: false),
                        UserDetails_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserDetails_Id)
                .Index(t => t.UserDetails_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        UserSubscriptionDetails_Id = c.Guid(),
                        Master_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscriptions", t => t.UserSubscriptionDetails_Id)
                .ForeignKey("dbo.Masters", t => t.Master_Id)
                .Index(t => t.UserSubscriptionDetails_Id)
                .Index(t => t.Master_Id);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Master_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Masters", t => t.Master_Id)
                .Index(t => t.Master_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoginDetails", "Id", "dbo.Users");
            DropForeignKey("dbo.Masters", "Id", "dbo.Users");
            DropForeignKey("dbo.Services", "Master_Id", "dbo.Masters");
            DropForeignKey("dbo.Partners", "Master_Id", "dbo.Masters");
            DropForeignKey("dbo.Modules", "Master_Id", "dbo.Masters");
            DropForeignKey("dbo.Services", "UserSubscriptionDetails_Id", "dbo.Subscriptions");
            DropForeignKey("dbo.Modules", "UserSubscriptionDetails_Id", "dbo.Subscriptions");
            DropForeignKey("dbo.Subscriptions", "UserDetails_Id", "dbo.Users");
            DropForeignKey("dbo.ContactDetails", "UserDetails_Id", "dbo.Users");
            DropForeignKey("dbo.Addresses", "UserDetails_Id", "dbo.Users");
            DropIndex("dbo.Partners", new[] { "Master_Id" });
            DropIndex("dbo.Services", new[] { "Master_Id" });
            DropIndex("dbo.Services", new[] { "UserSubscriptionDetails_Id" });
            DropIndex("dbo.Subscriptions", new[] { "UserDetails_Id" });
            DropIndex("dbo.Modules", new[] { "Master_Id" });
            DropIndex("dbo.Modules", new[] { "UserSubscriptionDetails_Id" });
            DropIndex("dbo.Masters", new[] { "Id" });
            DropIndex("dbo.ContactDetails", new[] { "UserDetails_Id" });
            DropIndex("dbo.Addresses", new[] { "UserDetails_Id" });
            DropIndex("dbo.LoginDetails", new[] { "Username" });
            DropIndex("dbo.LoginDetails", new[] { "Id" });
            DropTable("dbo.Partners");
            DropTable("dbo.Services");
            DropTable("dbo.Subscriptions");
            DropTable("dbo.Modules");
            DropTable("dbo.Masters");
            DropTable("dbo.ContactDetails");
            DropTable("dbo.Addresses");
            DropTable("dbo.Users");
            DropTable("dbo.LoginDetails");
            DropTable("dbo.Announcements");
        }
    }
}

namespace SimpleDeptApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deptDescFieldAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Description");
        }
    }
}

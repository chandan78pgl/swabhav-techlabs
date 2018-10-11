namespace EmpDeptMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeDeptAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            AddColumn("dbo.Employees", "EmpDepartment_Id", c => c.Guid());
            CreateIndex("dbo.Employees", "EmpDepartment_Id");
            AddForeignKey("dbo.Employees", "EmpDepartment_Id", "dbo.Departments", "Id");
            DropColumn("dbo.Employees", "Department_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Department_Id", c => c.Guid());
            DropForeignKey("dbo.Employees", "EmpDepartment_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "EmpDepartment_Id" });
            DropColumn("dbo.Employees", "EmpDepartment_Id");
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
    }
}

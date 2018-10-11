namespace EmpDeptMasterPageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpDeptAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DName = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmpName = c.String(),
                        EmpJob = c.String(),
                        EmpMGR = c.String(),
                        EmpHireDate = c.String(),
                        EmpSalary = c.Int(nullable: false),
                        EmpComm = c.Int(nullable: false),
                        EmpDepartment_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.EmpDepartment_Id)
                .Index(t => t.EmpDepartment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EmpDepartment_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "EmpDepartment_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}

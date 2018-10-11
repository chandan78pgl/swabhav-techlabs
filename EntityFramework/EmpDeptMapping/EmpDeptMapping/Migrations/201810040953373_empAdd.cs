namespace EmpDeptMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empAdd : DbMigration
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
                        Department_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}

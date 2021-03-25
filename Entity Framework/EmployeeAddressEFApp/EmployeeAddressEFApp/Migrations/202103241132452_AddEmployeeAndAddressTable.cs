namespace EmployeeAddressEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeAndAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAddress",
                c => new
                    {
                        AID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Employee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.AID)
                .ForeignKey("dbo.tblEmployee", t => t.Employee_ID)
                .Index(t => t.Employee_ID);
            
            CreateTable(
                "dbo.tblEmployee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        Job = c.String(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblAddress", "Employee_ID", "dbo.tblEmployee");
            DropIndex("dbo.tblAddress", new[] { "Employee_ID" });
            DropTable("dbo.tblEmployee");
            DropTable("dbo.tblAddress");
        }
    }
}

namespace CustomerOrderOneToManyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerAndOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCustomer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tblOrder",
                c => new
                    {
                        OID = c.Int(nullable: false, identity: true),
                        OrderName = c.String(),
                        Price = c.Double(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.OID)
                .ForeignKey("dbo.tblCustomer", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblOrder", "Customer_ID", "dbo.tblCustomer");
            DropIndex("dbo.tblOrder", new[] { "Customer_ID" });
            DropTable("dbo.tblOrder");
            DropTable("dbo.tblCustomer");
        }
    }
}

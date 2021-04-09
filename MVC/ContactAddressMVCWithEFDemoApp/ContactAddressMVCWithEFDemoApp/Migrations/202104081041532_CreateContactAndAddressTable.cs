namespace ContactAddressMVCWithEFDemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContactAndAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        ContactID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tblContact", t => t.ContactID, cascadeDelete: true)
                .Index(t => t.ContactID);
            
            CreateTable(
                "dbo.tblContact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblAddress", "ContactID", "dbo.tblContact");
            DropIndex("dbo.tblAddress", new[] { "ContactID" });
            DropTable("dbo.tblContact");
            DropTable("dbo.tblAddress");
        }
    }
}

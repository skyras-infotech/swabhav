namespace LayeredBasedContactApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustAddrTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Contact_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tblContact", t => t.Contact_ID)
                .Index(t => t.Contact_ID);
            
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
            DropForeignKey("dbo.tblAddress", "Contact_ID", "dbo.tblContact");
            DropIndex("dbo.tblAddress", new[] { "Contact_ID" });
            DropTable("dbo.tblContact");
            DropTable("dbo.tblAddress");
        }
    }
}

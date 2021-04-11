namespace ToDoListMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CreateToDoListTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblSubTasks",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true, defaultValueSql: "newid()"),
                    SubTaskName = c.String(nullable: false),
                    CreationDate = c.DateTime(nullable: false),
                    Status = c.String(nullable: false),
                    TasksID = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tblTasks", t => t.TasksID, cascadeDelete: true)
                .Index(t => t.TasksID);

            CreateTable(
                "dbo.tblTasks",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true, defaultValueSql: "newid()"),
                    TaskName = c.String(),
                    CreationDate = c.DateTime(nullable: false),
                    Status = c.String(),
                    UsersID = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tblUser", t => t.UsersID, cascadeDelete: true)
                .Index(t => t.UsersID);

            CreateTable(
                "dbo.tblUser",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true, defaultValueSql: "newid()"),
                    Username = c.String(nullable: false),
                    Password = c.String(nullable: false),
                    Role = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.tblTasks", "UsersID", "dbo.tblUser");
            DropForeignKey("dbo.tblSubTasks", "TasksID", "dbo.tblTasks");
            DropIndex("dbo.tblTasks", new[] { "UsersID" });
            DropIndex("dbo.tblSubTasks", new[] { "TasksID" });
            DropTable("dbo.tblUser");
            DropTable("dbo.tblTasks");
            DropTable("dbo.tblSubTasks");
        }
    }
}

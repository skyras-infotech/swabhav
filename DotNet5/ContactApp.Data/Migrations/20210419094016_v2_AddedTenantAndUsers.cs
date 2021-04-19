using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactApp.Data.Migrations
{
    public partial class v2_AddedTenantAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Contacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Tenants_TenantID",
                        column: x => x.TenantID,
                        principalTable: "Tenants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserID",
                table: "Contacts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TenantID",
                table: "Users",
                column: "TenantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserID",
                table: "Contacts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserID",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Contacts");
        }
    }
}

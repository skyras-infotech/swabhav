using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactApp.Data.Migrations
{
    public partial class v1MakeMobileFieldUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MobileNumber",
                table: "Contacts",
                column: "MobileNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_MobileNumber",
                table: "Contacts");
        }
    }
}

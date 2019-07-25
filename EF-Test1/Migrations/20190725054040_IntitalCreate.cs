using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Test1.Migrations
{
    public partial class IntitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Firts_Name",
                table: "Customers",
                newName: "First_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "First_Name",
                table: "Customers",
                newName: "Firts_Name");
        }
    }
}

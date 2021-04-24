using Microsoft.EntityFrameworkCore.Migrations;

namespace SpareParts.Migrations
{
    public partial class acc_add_password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "new_password",
                table: "new_account",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "new_password",
                table: "new_account");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SpareParts.Migrations
{
    public partial class acc_dep_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_new_account_department_new_department_id",
                table: "new_account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_department",
                table: "department");

            migrationBuilder.RenameTable(
                name: "department",
                newName: "new_department");

            migrationBuilder.AddPrimaryKey(
                name: "PK_new_department",
                table: "new_department",
                column: "new_department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_new_account_new_department_new_department_id",
                table: "new_account",
                column: "new_department_id",
                principalTable: "new_department",
                principalColumn: "new_department_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_new_account_new_department_new_department_id",
                table: "new_account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_new_department",
                table: "new_department");

            migrationBuilder.RenameTable(
                name: "new_department",
                newName: "department");

            migrationBuilder.AddPrimaryKey(
                name: "PK_department",
                table: "department",
                column: "new_department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_new_account_department_new_department_id",
                table: "new_account",
                column: "new_department_id",
                principalTable: "department",
                principalColumn: "new_department_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

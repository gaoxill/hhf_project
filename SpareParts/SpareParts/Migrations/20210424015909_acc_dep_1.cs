using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpareParts.Migrations
{
    public partial class acc_dep_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_new_account",
                table: "new_account");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "new_account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_new_account",
                table: "new_account",
                column: "new_account_id");

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    new_department_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    new_department_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_department_des = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_department_func = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_account_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.new_department_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_new_account_new_department_id",
                table: "new_account",
                column: "new_department_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_new_account_department_new_department_id",
                table: "new_account",
                column: "new_department_id",
                principalTable: "department",
                principalColumn: "new_department_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_new_account_department_new_department_id",
                table: "new_account");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_new_account",
                table: "new_account");

            migrationBuilder.DropIndex(
                name: "IX_new_account_new_department_id",
                table: "new_account");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "new_account",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_new_account",
                table: "new_account",
                column: "Id");
        }
    }
}

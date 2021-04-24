using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpareParts.Migrations
{
    public partial class acc_dep_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_new_account_new_department_new_department_id",
                table: "new_account");

            migrationBuilder.DropIndex(
                name: "IX_new_account_new_department_id",
                table: "new_account");

            migrationBuilder.AddColumn<Guid>(
                name: "new_department_id1",
                table: "new_account",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_new_account_new_department_id1",
                table: "new_account",
                column: "new_department_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_new_account_new_department_new_department_id1",
                table: "new_account",
                column: "new_department_id1",
                principalTable: "new_department",
                principalColumn: "new_department_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_new_account_new_department_new_department_id1",
                table: "new_account");

            migrationBuilder.DropIndex(
                name: "IX_new_account_new_department_id1",
                table: "new_account");

            migrationBuilder.DropColumn(
                name: "new_department_id1",
                table: "new_account");

            migrationBuilder.CreateIndex(
                name: "IX_new_account_new_department_id",
                table: "new_account",
                column: "new_department_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_new_account_new_department_new_department_id",
                table: "new_account",
                column: "new_department_id",
                principalTable: "new_department",
                principalColumn: "new_department_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

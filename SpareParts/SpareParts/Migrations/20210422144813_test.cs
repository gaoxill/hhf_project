using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpareParts.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "new_accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    new_account_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    new_account_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_account_mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_account_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_account_role = table.Column<int>(type: "int", nullable: false),
                    new_department_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_new_accounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "new_accounts");
        }
    }
}

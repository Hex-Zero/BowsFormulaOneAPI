using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOneAPI.Migrations
{
    public partial class addUserModelandseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[] { 1, new DateTime(2021, 10, 4, 12, 4, 6, 60, DateTimeKind.Local).AddTicks(8278), "r7jTG7dqBy5wGO4L", "Maxwell", false, "Archer", new DateTime(2021, 10, 4, 12, 4, 6, 62, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[] { 2, new DateTime(2021, 10, 4, 12, 4, 6, 62, DateTimeKind.Local).AddTicks(5937), "r7jTG8dqBy5wGO4L", "Alexandra", false, "Archer", new DateTime(2021, 10, 4, 12, 4, 6, 62, DateTimeKind.Local).AddTicks(5945) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

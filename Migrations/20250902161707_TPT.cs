using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Part__02_Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class TPT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountOfHours",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeType",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HourRate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "FullTimeEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FullTimeEmployees_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartTimeEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CountOfHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTimeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartTimeEmployees_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimeEmployees");

            migrationBuilder.DropTable(
                name: "PartTimeEmployees");

            migrationBuilder.AddColumn<int>(
                name: "CountOfHours",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeType",
                table: "Employees",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "HourRate",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);
        }
    }
}

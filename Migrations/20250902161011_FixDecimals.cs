using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Part__02_Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class FixDecimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeType",
                table: "Employees",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeType",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Employees",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");
        }
    }
}

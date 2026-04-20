using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class OwnedEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Street",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingCity",
                table: "Customers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAddress_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Street",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Street",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingCity",
                table: "Customers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class addcostcol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "CustomerService",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "CustomerService");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreatedBy", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "Customer 01", null },
                    { 2, null, "Customer 02", null },
                    { 3, null, "Customer 03", null }
                });
        }
    }
}

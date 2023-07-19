using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab12.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Layout",
                table: "rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "amenities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "AC" },
                    { 2, "coffeeBar" },
                    { 3, "Fridge" }
                });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "City", "Country", "Name", "Phone", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Amman", "JOR", "Royal", "079****", "Zahran", "5th.Circle" },
                    { 2, "Amman", "JOR", "4Seasons", "079****", "KFC", "5th.Circle" },
                    { 3, "Amman", "JOR", "Reds Carlton", "077****", "SHEC", "5th.Circle" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, 1, "honey" },
                    { 2, 2, "red" },
                    { 3, 3, "white" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Layout",
                table: "rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}

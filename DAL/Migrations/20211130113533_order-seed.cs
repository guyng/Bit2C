using Microsoft.EntityFrameworkCore.Migrations;

namespace Bit2C.Data.Migrations
{
    public partial class orderseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "OrderType", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, 84, 0, 648m, null },
                    { 2, 33, 0, 293m, null },
                    { 3, 37, 0, 200m, null },
                    { 4, 21, 0, 508m, null },
                    { 5, 5, 1, 976m, null },
                    { 6, 79, 1, 333m, null },
                    { 7, 70, 1, 776m, null },
                    { 8, 51, 1, 581m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

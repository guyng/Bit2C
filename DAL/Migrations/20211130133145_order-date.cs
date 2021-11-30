using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bit2C.Data.Migrations
{
    public partial class orderdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 43, new DateTime(2021, 11, 30, 15, 31, 45, 532, DateTimeKind.Local).AddTicks(5305), 124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 24, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(7782), 198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 69, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(7829), 703m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 69, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(7856), 997m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 55, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(7884), 155m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 77, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(7910), 662m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 89, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(7975), 248m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "OrderDate", "Price" },
                values: new object[] { 27, new DateTime(2021, 11, 30, 15, 31, 45, 534, DateTimeKind.Local).AddTicks(8003), 408m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 84, 648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 33, 293m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 37, 200m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 21, 508m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 5, 976m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 79, 333m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 70, 776m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 51, 581m });
        }
    }
}

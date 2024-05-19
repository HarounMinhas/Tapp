using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class StatusMetCollectieProjectenTakenToDos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 1,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 7, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 2,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 5, 6, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1914), new DateTime(2024, 5, 8, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 3,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 7, 11, 21, 11, 917, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 4,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 4, 7, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1922), new DateTime(2024, 6, 7, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 5,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1933), new DateTime(2024, 5, 7, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 6,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 9, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 7,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 4, 7, 13, 21, 11, 917, DateTimeKind.Local).AddTicks(1940) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 1,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 2,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 5, 5, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 5, 7, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 3,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 6, 18, 27, 35, 100, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 4,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 6, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 5,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 4, 26, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 5, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 6,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 8, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 7,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 4, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4158) });
        }
    }
}

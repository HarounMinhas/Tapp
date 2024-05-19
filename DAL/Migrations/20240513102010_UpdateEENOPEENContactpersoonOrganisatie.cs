using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEENOPEENContactpersoonOrganisatie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen");

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 1,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 13, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 2,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 5, 12, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6333), new DateTime(2024, 5, 14, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 3,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 13, 10, 20, 9, 601, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 4,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 4, 13, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 6, 13, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 5,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 5, 3, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 5, 13, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 6,
                column: "BeginDatumUur",
                value: new DateTime(2024, 5, 15, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "DatumUren",
                keyColumn: "DatumUurId",
                keyValue: 7,
                columns: new[] { "BeginDatumUur", "EindDatumUur" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 4, 13, 12, 20, 9, 601, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.CreateIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen",
                column: "OrganisatieId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen");

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

            migrationBuilder.CreateIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen",
                column: "OrganisatieId");
        }
    }
}

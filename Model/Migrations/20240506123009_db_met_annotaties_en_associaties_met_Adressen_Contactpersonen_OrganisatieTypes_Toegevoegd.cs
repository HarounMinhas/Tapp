using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class db_met_annotaties_en_associaties_met_Adressen_Contactpersonen_OrganisatieTypes_Toegevoegd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Organisaties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganisatieTypeId",
                table: "Organisaties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganisatieId",
                table: "Contactpersonen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Organisaties_AdresId",
                table: "Organisaties",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisaties_OrganisatieTypeId",
                table: "Organisaties",
                column: "OrganisatieTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen",
                column: "OrganisatieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactpersonen_Organisaties_OrganisatieId",
                table: "Contactpersonen",
                column: "OrganisatieId",
                principalTable: "Organisaties",
                principalColumn: "OrganisatieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisaties_Adressen_AdresId",
                table: "Organisaties",
                column: "AdresId",
                principalTable: "Adressen",
                principalColumn: "AdresId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisaties_OrganisatieTypes_OrganisatieTypeId",
                table: "Organisaties",
                column: "OrganisatieTypeId",
                principalTable: "OrganisatieTypes",
                principalColumn: "OrganisatieTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactpersonen_Organisaties_OrganisatieId",
                table: "Contactpersonen");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisaties_Adressen_AdresId",
                table: "Organisaties");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisaties_OrganisatieTypes_OrganisatieTypeId",
                table: "Organisaties");

            migrationBuilder.DropIndex(
                name: "IX_Organisaties_AdresId",
                table: "Organisaties");

            migrationBuilder.DropIndex(
                name: "IX_Organisaties_OrganisatieTypeId",
                table: "Organisaties");

            migrationBuilder.DropIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Organisaties");

            migrationBuilder.DropColumn(
                name: "OrganisatieTypeId",
                table: "Organisaties");

            migrationBuilder.DropColumn(
                name: "OrganisatieId",
                table: "Contactpersonen");
        }
    }
}

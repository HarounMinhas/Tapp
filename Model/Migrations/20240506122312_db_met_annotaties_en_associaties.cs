using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class db_met_annotaties_en_associaties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adressen",
                columns: table => new
                {
                    AdresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straatnaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Straatnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Busnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Land = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressen", x => x.AdresId);
                });

            migrationBuilder.CreateTable(
                name: "Contactpersonen",
                columns: table => new
                {
                    ContactpersoonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Familienaam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefoonNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSMNummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactpersonen", x => x.ContactpersoonId);
                });

            migrationBuilder.CreateTable(
                name: "DatumUren",
                columns: table => new
                {
                    DatumUurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDatumUur = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindDatumUur = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AfgerondDatumUur = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatumUren", x => x.DatumUurId);
                });

            migrationBuilder.CreateTable(
                name: "Organisaties",
                columns: table => new
                {
                    OrganisatieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTWNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rekeningnummer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisaties", x => x.OrganisatieId);
                });

            migrationBuilder.CreateTable(
                name: "OrganisatieTypes",
                columns: table => new
                {
                    OrganisatieTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisatieTypes", x => x.OrganisatieTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Statussen",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statussen", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Projecten",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisatieId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    DatumUurId = table.Column<int>(type: "int", nullable: true),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projecten", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projecten_DatumUren_DatumUurId",
                        column: x => x.DatumUurId,
                        principalTable: "DatumUren",
                        principalColumn: "DatumUurId");
                    table.ForeignKey(
                        name: "FK_Projecten_Organisaties_OrganisatieId",
                        column: x => x.OrganisatieId,
                        principalTable: "Organisaties",
                        principalColumn: "OrganisatieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projecten_Statussen_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statussen",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "Taken",
                columns: table => new
                {
                    TaakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    DatumUurId = table.Column<int>(type: "int", nullable: true),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taken", x => x.TaakId);
                    table.ForeignKey(
                        name: "FK_Taken_DatumUren_DatumUurId",
                        column: x => x.DatumUurId,
                        principalTable: "DatumUren",
                        principalColumn: "DatumUurId");
                    table.ForeignKey(
                        name: "FK_Taken_Projecten_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projecten",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Taken_Statussen_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statussen",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ToDoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumUurId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    TaakId = table.Column<int>(type: "int", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ToDoId);
                    table.ForeignKey(
                        name: "FK_ToDos_DatumUren_DatumUurId",
                        column: x => x.DatumUurId,
                        principalTable: "DatumUren",
                        principalColumn: "DatumUurId");
                    table.ForeignKey(
                        name: "FK_ToDos_Statussen_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statussen",
                        principalColumn: "StatusId");
                    table.ForeignKey(
                        name: "FK_ToDos_Taken_TaakId",
                        column: x => x.TaakId,
                        principalTable: "Taken",
                        principalColumn: "TaakId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    LabelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaakId = table.Column<int>(type: "int", nullable: true),
                    ToDoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.LabelId);
                    table.ForeignKey(
                        name: "FK_Labels_Taken_TaakId",
                        column: x => x.TaakId,
                        principalTable: "Taken",
                        principalColumn: "TaakId");
                    table.ForeignKey(
                        name: "FK_Labels_ToDos_ToDoId",
                        column: x => x.ToDoId,
                        principalTable: "ToDos",
                        principalColumn: "ToDoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Labels_TaakId",
                table: "Labels",
                column: "TaakId");

            migrationBuilder.CreateIndex(
                name: "IX_Labels_ToDoId",
                table: "Labels",
                column: "ToDoId");

            migrationBuilder.CreateIndex(
                name: "IX_Projecten_DatumUurId",
                table: "Projecten",
                column: "DatumUurId");

            migrationBuilder.CreateIndex(
                name: "IX_Projecten_OrganisatieId",
                table: "Projecten",
                column: "OrganisatieId");

            migrationBuilder.CreateIndex(
                name: "IX_Projecten_StatusId",
                table: "Projecten",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Taken_DatumUurId",
                table: "Taken",
                column: "DatumUurId");

            migrationBuilder.CreateIndex(
                name: "IX_Taken_ProjectId",
                table: "Taken",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Taken_StatusId",
                table: "Taken",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_DatumUurId",
                table: "ToDos",
                column: "DatumUurId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_StatusId",
                table: "ToDos",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_TaakId",
                table: "ToDos",
                column: "TaakId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adressen");

            migrationBuilder.DropTable(
                name: "Contactpersonen");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "OrganisatieTypes");

            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "Taken");

            migrationBuilder.DropTable(
                name: "Projecten");

            migrationBuilder.DropTable(
                name: "DatumUren");

            migrationBuilder.DropTable(
                name: "Organisaties");

            migrationBuilder.DropTable(
                name: "Statussen");
        }
    }
}

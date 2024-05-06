using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class DBAnnotationsassociatiesSeeded : Migration
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
                name: "Labels",
                columns: table => new
                {
                    LabelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.LabelId);
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
                name: "Organisaties",
                columns: table => new
                {
                    OrganisatieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTWNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rekeningnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisatieTypeId = table.Column<int>(type: "int", nullable: false),
                    AdresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisaties", x => x.OrganisatieId);
                    table.ForeignKey(
                        name: "FK_Organisaties_Adressen_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adressen",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organisaties_OrganisatieTypes_OrganisatieTypeId",
                        column: x => x.OrganisatieTypeId,
                        principalTable: "OrganisatieTypes",
                        principalColumn: "OrganisatieTypeId",
                        onDelete: ReferentialAction.Cascade);
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
                    GSMNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganisatieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactpersonen", x => x.ContactpersoonId);
                    table.ForeignKey(
                        name: "FK_Contactpersonen_Organisaties_OrganisatieId",
                        column: x => x.OrganisatieId,
                        principalTable: "Organisaties",
                        principalColumn: "OrganisatieId",
                        onDelete: ReferentialAction.Restrict);
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
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    LabelId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Taken_Labels_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Labels",
                        principalColumn: "LabelId",
                        onDelete: ReferentialAction.Restrict);
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
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabelId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_ToDos_Labels_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Labels",
                        principalColumn: "LabelId");
                    table.ForeignKey(
                        name: "FK_ToDos_Statussen_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statussen",
                        principalColumn: "StatusId");
                    table.ForeignKey(
                        name: "FK_ToDos_Taken_TaakId",
                        column: x => x.TaakId,
                        principalTable: "Taken",
                        principalColumn: "TaakId");
                });

            migrationBuilder.InsertData(
                table: "Adressen",
                columns: new[] { "AdresId", "Busnummer", "Gemeente", "Land", "Postcode", "Provincie", "Straatnaam", "Straatnummer" },
                values: new object[,]
                {
                    { 1, null, "Gent", "België", "9000", "Oost-Vlaanderen", "Tech Park", "21A" },
                    { 2, null, "Leuven", "België", "3001", "Vlaams-Brabant", "Greenway", "42B" },
                    { 3, null, "Oostende", "België", "8400", "West-Vlaanderen", "Ocean Drive", "88C" },
                    { 4, null, "Antwerpen", "België", "2000", "Antwerpen", "Quantum Leap", "101D" },
                    { 5, null, "Hasselt", "België", "3500", "Limburg", "Orbit Road", "360E" }
                });

            migrationBuilder.InsertData(
                table: "DatumUren",
                columns: new[] { "DatumUurId", "AfgerondDatumUur", "BeginDatumUur", "EindDatumUur" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 5, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4047), null },
                    { 2, null, new DateTime(2024, 5, 5, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 5, 7, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4119) },
                    { 3, null, new DateTime(2024, 5, 6, 18, 27, 35, 100, DateTimeKind.Local).AddTicks(4124), null },
                    { 4, null, new DateTime(2024, 4, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 6, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4137) },
                    { 5, null, new DateTime(2024, 4, 26, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 5, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4146) },
                    { 6, null, new DateTime(2024, 5, 8, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4150), null },
                    { 7, null, new DateTime(2024, 3, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 4, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4158) }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "LabelId", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { 1, "Tasks that need immediate attention", "Urgent" },
                    { 2, "Tasks that are of high priority but not urgent", "High Priority" },
                    { 3, "Tasks with a medium level of importance", "Medium Priority" },
                    { 4, "Tasks that can be deferred", "Low Priority" },
                    { 5, "Tasks that are optional and can be skipped if needed", "Optional" }
                });

            migrationBuilder.InsertData(
                table: "OrganisatieTypes",
                columns: new[] { "OrganisatieTypeId", "Naam" },
                values: new object[,]
                {
                    { 1, "BVBA" },
                    { 2, "NV" },
                    { 3, "Freelancer" },
                    { 4, "VZW" },
                    { 5, "Unief" }
                });

            migrationBuilder.InsertData(
                table: "Statussen",
                columns: new[] { "StatusId", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { 1, "Project is momenteel actief", "Actief" },
                    { 2, "Project is niet langer actief", "Niet actief" },
                    { 3, "Project is in revisie voor verbeteringen", "In revisie" }
                });

            migrationBuilder.InsertData(
                table: "Organisaties",
                columns: new[] { "OrganisatieId", "AdresId", "BTWNummer", "Naam", "OrganisatieTypeId", "Rekeningnummer" },
                values: new object[,]
                {
                    { 1, 1, "BE100200300", "NovaTech Solutions", 1, "BE68 1234 5678 9012" },
                    { 2, 2, "BE400500600", "EcoSynthetix Inc.", 2, "BE68 2345 6789 0123" },
                    { 3, 3, "BE700800900", "Hydra Renewables", 3, "BE68 3456 7890 1234" },
                    { 4, 4, "BE101112131", "Quantum Intelligence", 4, "BE68 4567 8901 2345" },
                    { 5, 5, "BE141516171", "Orbit Innovations", 5, "BE68 5678 9012 3456" }
                });

            migrationBuilder.InsertData(
                table: "Contactpersonen",
                columns: new[] { "ContactpersoonId", "Email", "Familienaam", "GSMNummer", "OrganisatieId", "TelefoonNummer", "Voornaam" },
                values: new object[,]
                {
                    { 1, "jan.devries@novatechsolutions.com", "De Vries", "0479123456", 1, "092342567", "Jan" },
                    { 2, "sara.peeters@ecosynthetixinc.com", "Peeters", "0478123456", 2, null, "Sara" },
                    { 3, "lucas.maes@hydrarenewables.com", "Maes", "0477223456", 3, null, "Lucas" },
                    { 4, "emma.jacobs@quantumintelligence.com", "Jacobs", "0476323456", 4, null, "Emma" },
                    { 5, "tom.janssens@orbitinnovations.com", "Janssens", "0475423456", 5, null, "Tom" }
                });

            migrationBuilder.InsertData(
                table: "Projecten",
                columns: new[] { "ProjectId", "Beschrijving", "DatumUurId", "Naam", "OrganisatieId", "StatusId" },
                values: new object[,]
                {
                    { 1, "Developing a new piece of software", 1, "Software Development", 1, 1 },
                    { 2, "Exploring renewable resources", 2, "Renewable Resources", 2, 1 },
                    { 3, "Analyzing current market trends", 3, "Market Analysis", 3, 1 },
                    { 4, "Working on AI technologies", 4, "AI Development", 4, 1 },
                    { 5, "Developing new educational programs", 5, "Educational Program", 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Taken",
                columns: new[] { "TaakId", "Beschrijving", "DatumUurId", "LabelId", "ProjectId", "StatusId", "Titel" },
                values: new object[,]
                {
                    { 1, "Designing user interfaces", 6, 2, 1, 1, "UI Design" },
                    { 2, "Creating backend services", 7, 1, 1, 1, "Backend Development" },
                    { 3, "Planning resource allocation", 1, 1, 2, 1, "Resource Planning" },
                    { 4, "Collecting market data", 2, 2, 3, 1, "Data Collection" },
                    { 5, "Optimizing existing algorithms", 3, 4, 4, 3, "Algorithm Optimization" },
                    { 6, "Reviewing environmental regulations", 4, 3, 2, 3, "Legal Review" },
                    { 7, "Developing community outreach programs", 5, 3, 2, 3, "Public Outreach" },
                    { 8, "Forecasting future market trends", 6, 2, 3, 2, "Market Forecasting" },
                    { 9, "Training neural networks for better performance", 7, 5, 4, 2, "Neural Network Training" },
                    { 10, "Developing new curriculum for upcoming courses", 1, 4, 5, 1, "Curriculum Development" }
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ToDoId", "Beschrijving", "DatumUurId", "LabelId", "StatusId", "TaakId", "Titel" },
                values: new object[,]
                {
                    { 1, "Sketching the initial designs for the UI", 4, 1, 1, 1, "Sketch Initial Designs" },
                    { 2, "Setting up the server environment", 5, 1, 1, 2, "Setup Server" },
                    { 3, "Drafting a report on resources", 6, 2, 1, 3, "Draft Resource Report" },
                    { 4, "Analyzing the collected data", 7, 3, 1, 4, "Analyze Collected Data" },
                    { 5, "Reviewing the algorithms for optimization", 1, 5, 3, 5, "Review Algorithms" },
                    { 6, "Consulting with legal advisors regarding compliance", 2, 4, 3, 6, "Consult Legal Advisors" },
                    { 7, "Preparing materials for public outreach", 3, 3, 3, 7, "Prepare Outreach Materials" },
                    { 8, "Compiling reports from collected market data", 4, 5, 2, 8, "Compile Data Reports" },
                    { 9, "Optimizing parameters for better accuracy", 5, 5, 2, 9, "Optimize Network Parameters" },
                    { 10, "Validating the developed curriculum with stakeholders", 6, 4, 2, 10, "Validate Curriculum" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactpersonen_OrganisatieId",
                table: "Contactpersonen",
                column: "OrganisatieId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisaties_AdresId",
                table: "Organisaties",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisaties_OrganisatieTypeId",
                table: "Organisaties",
                column: "OrganisatieTypeId");

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
                name: "IX_Taken_LabelId",
                table: "Taken",
                column: "LabelId");

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
                name: "IX_ToDos_LabelId",
                table: "ToDos",
                column: "LabelId");

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
                name: "Contactpersonen");

            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "Taken");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Projecten");

            migrationBuilder.DropTable(
                name: "DatumUren");

            migrationBuilder.DropTable(
                name: "Organisaties");

            migrationBuilder.DropTable(
                name: "Statussen");

            migrationBuilder.DropTable(
                name: "Adressen");

            migrationBuilder.DropTable(
                name: "OrganisatieTypes");
        }
    }
}

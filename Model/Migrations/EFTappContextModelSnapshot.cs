﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Entities;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(EFTappContext))]
    partial class EFTappContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Entities.Adres", b =>
                {
                    b.Property<int>("AdresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresId"));

                    b.Property<string>("Busnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straatnaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straatnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresId");

                    b.ToTable("Adressen");

                    b.HasData(
                        new
                        {
                            AdresId = 1,
                            Gemeente = "Gent",
                            Land = "België",
                            Postcode = "9000",
                            Provincie = "Oost-Vlaanderen",
                            Straatnaam = "Tech Park",
                            Straatnummer = "21A"
                        },
                        new
                        {
                            AdresId = 2,
                            Gemeente = "Leuven",
                            Land = "België",
                            Postcode = "3001",
                            Provincie = "Vlaams-Brabant",
                            Straatnaam = "Greenway",
                            Straatnummer = "42B"
                        },
                        new
                        {
                            AdresId = 3,
                            Gemeente = "Oostende",
                            Land = "België",
                            Postcode = "8400",
                            Provincie = "West-Vlaanderen",
                            Straatnaam = "Ocean Drive",
                            Straatnummer = "88C"
                        },
                        new
                        {
                            AdresId = 4,
                            Gemeente = "Antwerpen",
                            Land = "België",
                            Postcode = "2000",
                            Provincie = "Antwerpen",
                            Straatnaam = "Quantum Leap",
                            Straatnummer = "101D"
                        },
                        new
                        {
                            AdresId = 5,
                            Gemeente = "Hasselt",
                            Land = "België",
                            Postcode = "3500",
                            Provincie = "Limburg",
                            Straatnaam = "Orbit Road",
                            Straatnummer = "360E"
                        });
                });

            modelBuilder.Entity("Models.Entities.Contactpersoon", b =>
                {
                    b.Property<int>("ContactpersoonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactpersoonId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Familienaam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GSMNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisatieId")
                        .HasColumnType("int");

                    b.Property<string>("TelefoonNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ContactpersoonId");

                    b.HasIndex("OrganisatieId");

                    b.ToTable("Contactpersonen");

                    b.HasData(
                        new
                        {
                            ContactpersoonId = 1,
                            Email = "jan.devries@novatechsolutions.com",
                            Familienaam = "De Vries",
                            GSMNummer = "0479123456",
                            OrganisatieId = 1,
                            TelefoonNummer = "092342567",
                            Voornaam = "Jan"
                        },
                        new
                        {
                            ContactpersoonId = 2,
                            Email = "sara.peeters@ecosynthetixinc.com",
                            Familienaam = "Peeters",
                            GSMNummer = "0478123456",
                            OrganisatieId = 2,
                            Voornaam = "Sara"
                        },
                        new
                        {
                            ContactpersoonId = 3,
                            Email = "lucas.maes@hydrarenewables.com",
                            Familienaam = "Maes",
                            GSMNummer = "0477223456",
                            OrganisatieId = 3,
                            Voornaam = "Lucas"
                        },
                        new
                        {
                            ContactpersoonId = 4,
                            Email = "emma.jacobs@quantumintelligence.com",
                            Familienaam = "Jacobs",
                            GSMNummer = "0476323456",
                            OrganisatieId = 4,
                            Voornaam = "Emma"
                        },
                        new
                        {
                            ContactpersoonId = 5,
                            Email = "tom.janssens@orbitinnovations.com",
                            Familienaam = "Janssens",
                            GSMNummer = "0475423456",
                            OrganisatieId = 5,
                            Voornaam = "Tom"
                        });
                });

            modelBuilder.Entity("Models.Entities.DatumUur", b =>
                {
                    b.Property<int>("DatumUurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DatumUurId"));

                    b.Property<DateTime?>("AfgerondDatumUur")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BeginDatumUur")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EindDatumUur")
                        .HasColumnType("datetime2");

                    b.HasKey("DatumUurId");

                    b.ToTable("DatumUren");

                    b.HasData(
                        new
                        {
                            DatumUurId = 1,
                            BeginDatumUur = new DateTime(2024, 5, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4047)
                        },
                        new
                        {
                            DatumUurId = 2,
                            BeginDatumUur = new DateTime(2024, 5, 5, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4113),
                            EindDatumUur = new DateTime(2024, 5, 7, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4119)
                        },
                        new
                        {
                            DatumUurId = 3,
                            BeginDatumUur = new DateTime(2024, 5, 6, 18, 27, 35, 100, DateTimeKind.Local).AddTicks(4124)
                        },
                        new
                        {
                            DatumUurId = 4,
                            BeginDatumUur = new DateTime(2024, 4, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4131),
                            EindDatumUur = new DateTime(2024, 6, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4137)
                        },
                        new
                        {
                            DatumUurId = 5,
                            BeginDatumUur = new DateTime(2024, 4, 26, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4142),
                            EindDatumUur = new DateTime(2024, 5, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4146)
                        },
                        new
                        {
                            DatumUurId = 6,
                            BeginDatumUur = new DateTime(2024, 5, 8, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4150)
                        },
                        new
                        {
                            DatumUurId = 7,
                            BeginDatumUur = new DateTime(2024, 3, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4154),
                            EindDatumUur = new DateTime(2024, 4, 6, 20, 27, 35, 100, DateTimeKind.Local).AddTicks(4158)
                        });
                });

            modelBuilder.Entity("Models.Entities.Label", b =>
                {
                    b.Property<int>("LabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LabelId"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LabelId");

                    b.ToTable("Labels");

                    b.HasData(
                        new
                        {
                            LabelId = 1,
                            Beschrijving = "Tasks that need immediate attention",
                            Titel = "Urgent"
                        },
                        new
                        {
                            LabelId = 2,
                            Beschrijving = "Tasks that are of high priority but not urgent",
                            Titel = "High Priority"
                        },
                        new
                        {
                            LabelId = 3,
                            Beschrijving = "Tasks with a medium level of importance",
                            Titel = "Medium Priority"
                        },
                        new
                        {
                            LabelId = 4,
                            Beschrijving = "Tasks that can be deferred",
                            Titel = "Low Priority"
                        },
                        new
                        {
                            LabelId = 5,
                            Beschrijving = "Tasks that are optional and can be skipped if needed",
                            Titel = "Optional"
                        });
                });

            modelBuilder.Entity("Models.Entities.Organisatie", b =>
                {
                    b.Property<int>("OrganisatieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganisatieId"));

                    b.Property<int>("AdresId")
                        .HasColumnType("int");

                    b.Property<string>("BTWNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisatieTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Rekeningnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisatieId");

                    b.HasIndex("AdresId");

                    b.HasIndex("OrganisatieTypeId");

                    b.ToTable("Organisaties");

                    b.HasData(
                        new
                        {
                            OrganisatieId = 1,
                            AdresId = 1,
                            BTWNummer = "BE100200300",
                            Naam = "NovaTech Solutions",
                            OrganisatieTypeId = 1,
                            Rekeningnummer = "BE68 1234 5678 9012"
                        },
                        new
                        {
                            OrganisatieId = 2,
                            AdresId = 2,
                            BTWNummer = "BE400500600",
                            Naam = "EcoSynthetix Inc.",
                            OrganisatieTypeId = 2,
                            Rekeningnummer = "BE68 2345 6789 0123"
                        },
                        new
                        {
                            OrganisatieId = 3,
                            AdresId = 3,
                            BTWNummer = "BE700800900",
                            Naam = "Hydra Renewables",
                            OrganisatieTypeId = 3,
                            Rekeningnummer = "BE68 3456 7890 1234"
                        },
                        new
                        {
                            OrganisatieId = 4,
                            AdresId = 4,
                            BTWNummer = "BE101112131",
                            Naam = "Quantum Intelligence",
                            OrganisatieTypeId = 4,
                            Rekeningnummer = "BE68 4567 8901 2345"
                        },
                        new
                        {
                            OrganisatieId = 5,
                            AdresId = 5,
                            BTWNummer = "BE141516171",
                            Naam = "Orbit Innovations",
                            OrganisatieTypeId = 5,
                            Rekeningnummer = "BE68 5678 9012 3456"
                        });
                });

            modelBuilder.Entity("Models.Entities.OrganisatieType", b =>
                {
                    b.Property<int>("OrganisatieTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganisatieTypeId"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisatieTypeId");

                    b.ToTable("OrganisatieTypes");

                    b.HasData(
                        new
                        {
                            OrganisatieTypeId = 1,
                            Naam = "BVBA"
                        },
                        new
                        {
                            OrganisatieTypeId = 2,
                            Naam = "NV"
                        },
                        new
                        {
                            OrganisatieTypeId = 3,
                            Naam = "Freelancer"
                        },
                        new
                        {
                            OrganisatieTypeId = 4,
                            Naam = "VZW"
                        },
                        new
                        {
                            OrganisatieTypeId = 5,
                            Naam = "Unief"
                        });
                });

            modelBuilder.Entity("Models.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DatumUurId")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisatieId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.HasIndex("DatumUurId");

                    b.HasIndex("OrganisatieId");

                    b.HasIndex("StatusId");

                    b.ToTable("Projecten");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Beschrijving = "Developing a new piece of software",
                            DatumUurId = 1,
                            Naam = "Software Development",
                            OrganisatieId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            ProjectId = 2,
                            Beschrijving = "Exploring renewable resources",
                            DatumUurId = 2,
                            Naam = "Renewable Resources",
                            OrganisatieId = 2,
                            StatusId = 1
                        },
                        new
                        {
                            ProjectId = 3,
                            Beschrijving = "Analyzing current market trends",
                            DatumUurId = 3,
                            Naam = "Market Analysis",
                            OrganisatieId = 3,
                            StatusId = 1
                        },
                        new
                        {
                            ProjectId = 4,
                            Beschrijving = "Working on AI technologies",
                            DatumUurId = 4,
                            Naam = "AI Development",
                            OrganisatieId = 4,
                            StatusId = 1
                        },
                        new
                        {
                            ProjectId = 5,
                            Beschrijving = "Developing new educational programs",
                            DatumUurId = 5,
                            Naam = "Educational Program",
                            OrganisatieId = 5,
                            StatusId = 3
                        });
                });

            modelBuilder.Entity("Models.Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statussen");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            Beschrijving = "Project is momenteel actief",
                            Titel = "Actief"
                        },
                        new
                        {
                            StatusId = 2,
                            Beschrijving = "Project is niet langer actief",
                            Titel = "Niet actief"
                        },
                        new
                        {
                            StatusId = 3,
                            Beschrijving = "Project is in revisie voor verbeteringen",
                            Titel = "In revisie"
                        });
                });

            modelBuilder.Entity("Models.Entities.Taak", b =>
                {
                    b.Property<int>("TaakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaakId"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DatumUurId")
                        .HasColumnType("int");

                    b.Property<int?>("LabelId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaakId");

                    b.HasIndex("DatumUurId");

                    b.HasIndex("LabelId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId");

                    b.ToTable("Taken");

                    b.HasData(
                        new
                        {
                            TaakId = 1,
                            Beschrijving = "Designing user interfaces",
                            DatumUurId = 6,
                            LabelId = 2,
                            ProjectId = 1,
                            StatusId = 1,
                            Titel = "UI Design"
                        },
                        new
                        {
                            TaakId = 2,
                            Beschrijving = "Creating backend services",
                            DatumUurId = 7,
                            LabelId = 1,
                            ProjectId = 1,
                            StatusId = 1,
                            Titel = "Backend Development"
                        },
                        new
                        {
                            TaakId = 3,
                            Beschrijving = "Planning resource allocation",
                            DatumUurId = 1,
                            LabelId = 1,
                            ProjectId = 2,
                            StatusId = 1,
                            Titel = "Resource Planning"
                        },
                        new
                        {
                            TaakId = 4,
                            Beschrijving = "Collecting market data",
                            DatumUurId = 2,
                            LabelId = 2,
                            ProjectId = 3,
                            StatusId = 1,
                            Titel = "Data Collection"
                        },
                        new
                        {
                            TaakId = 5,
                            Beschrijving = "Optimizing existing algorithms",
                            DatumUurId = 3,
                            LabelId = 4,
                            ProjectId = 4,
                            StatusId = 3,
                            Titel = "Algorithm Optimization"
                        },
                        new
                        {
                            TaakId = 6,
                            Beschrijving = "Reviewing environmental regulations",
                            DatumUurId = 4,
                            LabelId = 3,
                            ProjectId = 2,
                            StatusId = 3,
                            Titel = "Legal Review"
                        },
                        new
                        {
                            TaakId = 7,
                            Beschrijving = "Developing community outreach programs",
                            DatumUurId = 5,
                            LabelId = 3,
                            ProjectId = 2,
                            StatusId = 3,
                            Titel = "Public Outreach"
                        },
                        new
                        {
                            TaakId = 8,
                            Beschrijving = "Forecasting future market trends",
                            DatumUurId = 6,
                            LabelId = 2,
                            ProjectId = 3,
                            StatusId = 2,
                            Titel = "Market Forecasting"
                        },
                        new
                        {
                            TaakId = 9,
                            Beschrijving = "Training neural networks for better performance",
                            DatumUurId = 7,
                            LabelId = 5,
                            ProjectId = 4,
                            StatusId = 2,
                            Titel = "Neural Network Training"
                        },
                        new
                        {
                            TaakId = 10,
                            Beschrijving = "Developing new curriculum for upcoming courses",
                            DatumUurId = 1,
                            LabelId = 4,
                            ProjectId = 5,
                            StatusId = 1,
                            Titel = "Curriculum Development"
                        });
                });

            modelBuilder.Entity("Models.Entities.ToDo", b =>
                {
                    b.Property<int>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToDoId"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DatumUurId")
                        .HasColumnType("int");

                    b.Property<int?>("LabelId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TaakId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToDoId");

                    b.HasIndex("DatumUurId");

                    b.HasIndex("LabelId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TaakId");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            ToDoId = 1,
                            Beschrijving = "Sketching the initial designs for the UI",
                            DatumUurId = 4,
                            LabelId = 1,
                            StatusId = 1,
                            TaakId = 1,
                            Titel = "Sketch Initial Designs"
                        },
                        new
                        {
                            ToDoId = 2,
                            Beschrijving = "Setting up the server environment",
                            DatumUurId = 5,
                            LabelId = 1,
                            StatusId = 1,
                            TaakId = 2,
                            Titel = "Setup Server"
                        },
                        new
                        {
                            ToDoId = 3,
                            Beschrijving = "Drafting a report on resources",
                            DatumUurId = 6,
                            LabelId = 2,
                            StatusId = 1,
                            TaakId = 3,
                            Titel = "Draft Resource Report"
                        },
                        new
                        {
                            ToDoId = 4,
                            Beschrijving = "Analyzing the collected data",
                            DatumUurId = 7,
                            LabelId = 3,
                            StatusId = 1,
                            TaakId = 4,
                            Titel = "Analyze Collected Data"
                        },
                        new
                        {
                            ToDoId = 5,
                            Beschrijving = "Reviewing the algorithms for optimization",
                            DatumUurId = 1,
                            LabelId = 5,
                            StatusId = 3,
                            TaakId = 5,
                            Titel = "Review Algorithms"
                        },
                        new
                        {
                            ToDoId = 6,
                            Beschrijving = "Consulting with legal advisors regarding compliance",
                            DatumUurId = 2,
                            LabelId = 4,
                            StatusId = 3,
                            TaakId = 6,
                            Titel = "Consult Legal Advisors"
                        },
                        new
                        {
                            ToDoId = 7,
                            Beschrijving = "Preparing materials for public outreach",
                            DatumUurId = 3,
                            LabelId = 3,
                            StatusId = 3,
                            TaakId = 7,
                            Titel = "Prepare Outreach Materials"
                        },
                        new
                        {
                            ToDoId = 8,
                            Beschrijving = "Compiling reports from collected market data",
                            DatumUurId = 4,
                            LabelId = 5,
                            StatusId = 2,
                            TaakId = 8,
                            Titel = "Compile Data Reports"
                        },
                        new
                        {
                            ToDoId = 9,
                            Beschrijving = "Optimizing parameters for better accuracy",
                            DatumUurId = 5,
                            LabelId = 5,
                            StatusId = 2,
                            TaakId = 9,
                            Titel = "Optimize Network Parameters"
                        },
                        new
                        {
                            ToDoId = 10,
                            Beschrijving = "Validating the developed curriculum with stakeholders",
                            DatumUurId = 6,
                            LabelId = 4,
                            StatusId = 2,
                            TaakId = 10,
                            Titel = "Validate Curriculum"
                        });
                });

            modelBuilder.Entity("Models.Entities.Contactpersoon", b =>
                {
                    b.HasOne("Models.Entities.Organisatie", "Organisatie")
                        .WithMany("Contactpersonen")
                        .HasForeignKey("OrganisatieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organisatie");
                });

            modelBuilder.Entity("Models.Entities.Organisatie", b =>
                {
                    b.HasOne("Models.Entities.Adres", "Adres")
                        .WithMany()
                        .HasForeignKey("AdresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.OrganisatieType", "OrganisatieType")
                        .WithMany()
                        .HasForeignKey("OrganisatieTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adres");

                    b.Navigation("OrganisatieType");
                });

            modelBuilder.Entity("Models.Entities.Project", b =>
                {
                    b.HasOne("Models.Entities.DatumUur", "DatumUur")
                        .WithMany()
                        .HasForeignKey("DatumUurId");

                    b.HasOne("Models.Entities.Organisatie", "Organisatie")
                        .WithMany()
                        .HasForeignKey("OrganisatieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("DatumUur");

                    b.Navigation("Organisatie");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Models.Entities.Taak", b =>
                {
                    b.HasOne("Models.Entities.DatumUur", "DatumUur")
                        .WithMany()
                        .HasForeignKey("DatumUurId");

                    b.HasOne("Models.Entities.Label", "Label")
                        .WithMany("Taken")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Entities.Project", "Project")
                        .WithMany("Taken")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("DatumUur");

                    b.Navigation("Label");

                    b.Navigation("Project");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Models.Entities.ToDo", b =>
                {
                    b.HasOne("Models.Entities.DatumUur", "DatumUur")
                        .WithMany()
                        .HasForeignKey("DatumUurId");

                    b.HasOne("Models.Entities.Label", "Label")
                        .WithMany("ToDos")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Models.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Models.Entities.Taak", "Taak")
                        .WithMany("ToDos")
                        .HasForeignKey("TaakId")
                        .IsRequired();

                    b.Navigation("DatumUur");

                    b.Navigation("Label");

                    b.Navigation("Status");

                    b.Navigation("Taak");
                });

            modelBuilder.Entity("Models.Entities.Label", b =>
                {
                    b.Navigation("Taken");

                    b.Navigation("ToDos");
                });

            modelBuilder.Entity("Models.Entities.Organisatie", b =>
                {
                    b.Navigation("Contactpersonen");
                });

            modelBuilder.Entity("Models.Entities.Project", b =>
                {
                    b.Navigation("Taken");
                });

            modelBuilder.Entity("Models.Entities.Taak", b =>
                {
                    b.Navigation("ToDos");
                });
#pragma warning restore 612, 618
        }
    }
}

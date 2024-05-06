﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Entities;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(EFTappContext))]
    [Migration("20240506123009_db_met_annotaties_en_associaties_met_Adressen_Contactpersonen_OrganisatieTypes_Toegevoegd")]
    partial class db_met_annotaties_en_associaties_met_Adressen_Contactpersonen_OrganisatieTypes_Toegevoegd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("TaakId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToDoId")
                        .HasColumnType("int");

                    b.HasKey("LabelId");

                    b.HasIndex("TaakId");

                    b.HasIndex("ToDoId");

                    b.ToTable("Labels");
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

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaakId");

                    b.HasIndex("DatumUurId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId");

                    b.ToTable("Taken");
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

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TaakId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToDoId");

                    b.HasIndex("DatumUurId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TaakId");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("Models.Entities.Contactpersoon", b =>
                {
                    b.HasOne("Models.Entities.Organisatie", "Organisatie")
                        .WithMany("Contactpersonen")
                        .HasForeignKey("OrganisatieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisatie");
                });

            modelBuilder.Entity("Models.Entities.Label", b =>
                {
                    b.HasOne("Models.Entities.Taak", null)
                        .WithMany("Labels")
                        .HasForeignKey("TaakId");

                    b.HasOne("Models.Entities.ToDo", null)
                        .WithMany("Labels")
                        .HasForeignKey("ToDoId");
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

                    b.HasOne("Models.Entities.Project", "Project")
                        .WithMany("Taken")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("DatumUur");

                    b.Navigation("Project");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Models.Entities.ToDo", b =>
                {
                    b.HasOne("Models.Entities.DatumUur", "DatumUur")
                        .WithMany()
                        .HasForeignKey("DatumUurId");

                    b.HasOne("Models.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Models.Entities.Taak", "Taak")
                        .WithMany("ToDos")
                        .HasForeignKey("TaakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DatumUur");

                    b.Navigation("Status");

                    b.Navigation("Taak");
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
                    b.Navigation("Labels");

                    b.Navigation("ToDos");
                });

            modelBuilder.Entity("Models.Entities.ToDo", b =>
                {
                    b.Navigation("Labels");
                });
#pragma warning restore 612, 618
        }
    }
}

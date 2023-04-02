﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projekt.Data;

#nullable disable

namespace projekt.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("projekt.Models.Miejscowosci", b =>
                {
                    b.Property<int>("idmiejscowosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("kraj_miejscowosci")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nazwa_miejscowosci")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idmiejscowosci");

                    b.ToTable("miejscowosci", (string)null);
                });

            modelBuilder.Entity("projekt.Models.Wyniki", b =>
                {
                    b.Property<int>("idwyniki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idmiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("idzawodnicy")
                        .HasColumnType("int");

                    b.Property<int>("wynik")
                        .HasColumnType("int");

                    b.HasKey("idwyniki");

                    b.ToTable("wyniki", (string)null);
                });

            modelBuilder.Entity("projekt.Models.Zawodnik", b =>
                {
                    b.Property<int>("idzawodnicy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("imie_zawodnika")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("kraj_pochodzenia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nazwisko_zawodnika")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idzawodnicy");

                    b.ToTable("zawodnicy", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

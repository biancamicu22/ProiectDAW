﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectDAW.Data;

namespace ProiectDAW.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220124145613_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectMDS.Models.Atractie", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OraDeschidere")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("OraInchidere")
                        .HasColumnType("time");

                    b.Property<string>("Oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Atractii");
                });

            modelBuilder.Entity("ProiectMDS.Models.Bilet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AtractieID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodBilet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataVizita")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VacantaID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("AtractieID");

                    b.HasIndex("VacantaID");

                    b.ToTable("Bilete");
                });

            modelBuilder.Entity("ProiectMDS.Models.Cazare", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.Property<string>("TipCazare")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Cazari");
                });

            modelBuilder.Entity("ProiectMDS.Models.Facilitate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Facilitati");
                });

            modelBuilder.Entity("ProiectMDS.Models.Fotografie", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titlu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UtilizatorID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UtilizatorID");

                    b.ToTable("Fotografii");
                });

            modelBuilder.Entity("ProiectMDS.Models.Pachet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CazareID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FacilitateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("FacilitateID1")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CazareID");

                    b.HasIndex("FacilitateID1");

                    b.ToTable("Pachete");
                });

            modelBuilder.Entity("ProiectMDS.Models.Portofel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<float>("Suma")
                        .HasColumnType("real");

                    b.Property<Guid>("UtilizatorID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UtilizatorID")
                        .IsUnique();

                    b.ToTable("Portofel");
                });

            modelBuilder.Entity("ProiectMDS.Models.Rezervare", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataRezervare")
                        .HasColumnType("Date");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UtilizatorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VacantaID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UtilizatorID");

                    b.HasIndex("VacantaID");

                    b.ToTable("Rezervari");
                });

            modelBuilder.Entity("ProiectMDS.Models.RezervareCazare", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CazareID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodRezervare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPlecare")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataSosire")
                        .HasColumnType("Date");

                    b.Property<Guid>("VacantaID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CazareID");

                    b.HasIndex("VacantaID");

                    b.ToTable("RezervariCazari");
                });

            modelBuilder.Entity("ProiectMDS.Models.Utilizator", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNasterii")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Utilizatori");
                });

            modelBuilder.Entity("ProiectMDS.Models.Vacanta", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("Date");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tara")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Vacante");
                });

            modelBuilder.Entity("ProiectMDS.Models.Bilet", b =>
                {
                    b.HasOne("ProiectMDS.Models.Atractie", "Atractie")
                        .WithMany("Bilet")
                        .HasForeignKey("AtractieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectMDS.Models.Vacanta", "Vacanta")
                        .WithMany("Bilet")
                        .HasForeignKey("VacantaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atractie");

                    b.Navigation("Vacanta");
                });

            modelBuilder.Entity("ProiectMDS.Models.Fotografie", b =>
                {
                    b.HasOne("ProiectMDS.Models.Utilizator", "Utilizator")
                        .WithMany("Fotografie")
                        .HasForeignKey("UtilizatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizator");
                });

            modelBuilder.Entity("ProiectMDS.Models.Pachet", b =>
                {
                    b.HasOne("ProiectMDS.Models.Cazare", "Cazare")
                        .WithMany("Pachet")
                        .HasForeignKey("CazareID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectMDS.Models.Facilitate", "Facilitate")
                        .WithMany("Pachet")
                        .HasForeignKey("FacilitateID1");

                    b.Navigation("Cazare");

                    b.Navigation("Facilitate");
                });

            modelBuilder.Entity("ProiectMDS.Models.Portofel", b =>
                {
                    b.HasOne("ProiectMDS.Models.Utilizator", "Utilizator")
                        .WithOne("Portofel")
                        .HasForeignKey("ProiectMDS.Models.Portofel", "UtilizatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizator");
                });

            modelBuilder.Entity("ProiectMDS.Models.Rezervare", b =>
                {
                    b.HasOne("ProiectMDS.Models.Utilizator", "Utilizator")
                        .WithMany("Rezervare")
                        .HasForeignKey("UtilizatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectMDS.Models.Vacanta", "Vacanta")
                        .WithMany("Rezervare")
                        .HasForeignKey("VacantaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizator");

                    b.Navigation("Vacanta");
                });

            modelBuilder.Entity("ProiectMDS.Models.RezervareCazare", b =>
                {
                    b.HasOne("ProiectMDS.Models.Cazare", "Cazare")
                        .WithMany("RezervareCazare")
                        .HasForeignKey("CazareID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectMDS.Models.Vacanta", "Vacanta")
                        .WithMany("RezervareCazare")
                        .HasForeignKey("VacantaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cazare");

                    b.Navigation("Vacanta");
                });

            modelBuilder.Entity("ProiectMDS.Models.Atractie", b =>
                {
                    b.Navigation("Bilet");
                });

            modelBuilder.Entity("ProiectMDS.Models.Cazare", b =>
                {
                    b.Navigation("Pachet");

                    b.Navigation("RezervareCazare");
                });

            modelBuilder.Entity("ProiectMDS.Models.Facilitate", b =>
                {
                    b.Navigation("Pachet");
                });

            modelBuilder.Entity("ProiectMDS.Models.Utilizator", b =>
                {
                    b.Navigation("Fotografie");

                    b.Navigation("Portofel");

                    b.Navigation("Rezervare");
                });

            modelBuilder.Entity("ProiectMDS.Models.Vacanta", b =>
                {
                    b.Navigation("Bilet");

                    b.Navigation("Rezervare");

                    b.Navigation("RezervareCazare");
                });
#pragma warning restore 612, 618
        }
    }
}
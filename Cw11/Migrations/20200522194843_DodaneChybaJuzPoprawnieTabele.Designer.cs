﻿// <auto-generated />
using System;
using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cw11.Migrations
{
    [DbContext(typeof(s18309DbContext))]
    [Migration("20200522194843_DodaneChybaJuzPoprawnieTabele")]
    partial class DodaneChybaJuzPoprawnieTabele
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor")
                        .HasName("DoctorPrimaryKey");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "1@as.d",
                            FirstName = "Mateusz",
                            LastName = "Rudy"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "2@as.d",
                            FirstName = "Adam",
                            LastName = "Blady"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "3@as.d",
                            FirstName = "Slawek",
                            LastName = "Niebieski"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "4@as.d",
                            FirstName = "Krzys",
                            LastName = "Pomaranczowy"
                        },
                        new
                        {
                            IdDoctor = 5,
                            Email = "5@as.d",
                            FirstName = "Wojtek",
                            LastName = "Rozowy"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament")
                        .HasName("MedicamentPrimaryKey");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "qqqqqqqqqqq",
                            Name = "jeden",
                            Type = "a"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "wwwwwwwwwwww",
                            Name = "dwa",
                            Type = "b"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "eeeeeeeeeee",
                            Name = "trzy",
                            Type = "a"
                        },
                        new
                        {
                            IdMedicament = 4,
                            Description = "rrrrrrrrr",
                            Name = "cztery",
                            Type = "b"
                        },
                        new
                        {
                            IdMedicament = 5,
                            Description = "tttttttttt",
                            Name = "piec",
                            Type = "a"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient")
                        .HasName("PatientPrimaryKey");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2020, 5, 22, 21, 48, 43, 481, DateTimeKind.Local).AddTicks(6303),
                            FirstName = "Anna",
                            LastName = "Kowalska"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7136),
                            FirstName = "Angelika",
                            LastName = "Red"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7171),
                            FirstName = "Sylwia",
                            LastName = "Amasde"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7177),
                            FirstName = "Sasha",
                            LastName = "Jakubiak"
                        },
                        new
                        {
                            IdPatient = 5,
                            BirthDate = new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7180),
                            FirstName = "Renata",
                            LastName = "Smark"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("PrescriptionPrimaryKey");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(3417),
                            DueDate = new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(3839),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(4963),
                            DueDate = new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(4987),
                            IdDoctor = 2,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(5007),
                            DueDate = new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(5010),
                            IdDoctor = 3,
                            IdPatient = 3
                        },
                        new
                        {
                            IdPrescription = 4,
                            Date = new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(5013),
                            DueDate = new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(5016),
                            IdDoctor = 4,
                            IdPatient = 4
                        },
                        new
                        {
                            IdPrescription = 5,
                            Date = new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(5019),
                            DueDate = new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(5022),
                            IdDoctor = 5,
                            IdPatient = 5
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "aaaaaa",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "sssssssssss",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 3,
                            IdPrescription = 3,
                            Details = "dddddddd",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 4,
                            IdPrescription = 4,
                            Details = "ffffffffffffff",
                            Dose = 1
                        },
                        new
                        {
                            IdMedicament = 5,
                            IdPrescription = 5,
                            Details = "ggggggggggggggggggg",
                            Dose = 1
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription", b =>
                {
                    b.HasOne("Cw11.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .HasConstraintName("DoctorPrescription")
                        .IsRequired();

                    b.HasOne("Cw11.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .HasConstraintName("PatientPrescription")
                        .IsRequired();
                });

            modelBuilder.Entity("Cw11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("Cw11.Models.Medicament", "Medicament")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .HasConstraintName("MedicamentWithPrescriptionMedicament")
                        .IsRequired();

                    b.HasOne("Cw11.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .HasConstraintName("PrescriptionWithPrescriptionMedicament")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

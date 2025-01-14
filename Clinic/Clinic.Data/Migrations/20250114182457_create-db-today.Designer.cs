﻿// <auto-generated />
using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clinic.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250114182457_create-db-today")]
    partial class createdbtoday
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Clinic.Core.Models.Doctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Doctor_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("Clinic.Core.Models.Patient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("above18")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Clinic.Core.Models.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Date_passed")
                        .HasColumnType("bit");

                    b.Property<string>("Desecription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId")
                        .IsUnique();

                    b.HasIndex("PatientId");

                    b.ToTable("prescriptions");
                });

            modelBuilder.Entity("Clinic.Core.Models.Prescription", b =>
                {
                    b.HasOne("Clinic.Core.Models.Doctor", "doctor")
                        .WithOne("prescription")
                        .HasForeignKey("Clinic.Core.Models.Prescription", "DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinic.Core.Models.Patient", "patient")
                        .WithMany("prescriptionsList")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Clinic.Core.Models.Doctor", b =>
                {
                    b.Navigation("prescription")
                        .IsRequired();
                });

            modelBuilder.Entity("Clinic.Core.Models.Patient", b =>
                {
                    b.Navigation("prescriptionsList");
                });
#pragma warning restore 612, 618
        }
    }
}
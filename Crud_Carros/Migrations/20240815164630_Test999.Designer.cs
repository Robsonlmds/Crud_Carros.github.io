﻿// <auto-generated />
using System;
using Crud_Carros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crud_Carros.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240815164630_Test999")]
    partial class Test999
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Crud_Carros.Models.Entities.Car", b =>
                {
                    b.Property<Guid>("Id_Car")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IPVA")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModelOfCarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate_Car")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year_Car")
                        .HasColumnType("int");

                    b.HasKey("Id_Car");

                    b.HasIndex("ModelOfCarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.Client", b =>
                {
                    b.Property<Guid>("Id_Client")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Name_Client")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contact")
                        .HasColumnType("int");

                    b.HasKey("Id_Client");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.ClientOfStaff", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StaffId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClientId", "StaffId");

                    b.HasIndex("StaffId");

                    b.ToTable("ClientOfStaffs");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.ModelOfCar", b =>
                {
                    b.Property<Guid>("Id_ModelOfCar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_ModelOfCar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StaffId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id_ModelOfCar");

                    b.HasIndex("StaffId");

                    b.ToTable("ModelsOfCar");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.Staff", b =>
                {
                    b.Property<Guid>("Id_Staff")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Local_Staff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Staff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Postalcode")
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.HasKey("Id_Staff");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.Car", b =>
                {
                    b.HasOne("Crud_Carros.Models.Entities.ModelOfCar", "ModelOfCar")
                        .WithMany()
                        .HasForeignKey("ModelOfCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelOfCar");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.ClientOfStaff", b =>
                {
                    b.HasOne("Crud_Carros.Models.Entities.Client", "Client")
                        .WithMany("ClientOfStaffs")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud_Carros.Models.Entities.Staff", "Staff")
                        .WithMany("ClientOfStaffs")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.ModelOfCar", b =>
                {
                    b.HasOne("Crud_Carros.Models.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.Client", b =>
                {
                    b.Navigation("ClientOfStaffs");
                });

            modelBuilder.Entity("Crud_Carros.Models.Entities.Staff", b =>
                {
                    b.Navigation("ClientOfStaffs");
                });
#pragma warning restore 612, 618
        }
    }
}

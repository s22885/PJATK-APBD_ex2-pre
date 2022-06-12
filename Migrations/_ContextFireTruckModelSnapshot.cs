﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PreKolos2.Entities;

namespace PreKolos2.Migrations
{
    [DbContext(typeof(_ContextFireTruck))]
    partial class _ContextFireTruckModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PreKolos2.Entities.Action", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NeedSpecialEquipment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAction")
                        .HasName("Action_pk");

                    b.ToTable("Action");

                    b.HasData(
                        new
                        {
                            IdAction = 1,
                            EndTime = new DateTime(2013, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NeedSpecialEquipment = true,
                            StartTime = new DateTime(2012, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdAction = 2,
                            EndTime = new DateTime(2014, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NeedSpecialEquipment = true,
                            StartTime = new DateTime(2013, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdAction = 3,
                            EndTime = new DateTime(2015, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NeedSpecialEquipment = false,
                            StartTime = new DateTime(2014, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PreKolos2.Entities.FireTruck", b =>
                {
                    b.Property<int>("IdFiretruck")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("SpecialEquipment")
                        .HasColumnType("bit");

                    b.HasKey("IdFiretruck")
                        .HasName("FireTruck_pk");

                    b.ToTable("FireTruck");

                    b.HasData(
                        new
                        {
                            IdFiretruck = 1,
                            OperationNumber = "2137",
                            SpecialEquipment = true
                        },
                        new
                        {
                            IdFiretruck = 2,
                            OperationNumber = "69420",
                            SpecialEquipment = true
                        },
                        new
                        {
                            IdFiretruck = 3,
                            OperationNumber = "42069",
                            SpecialEquipment = false
                        });
                });

            modelBuilder.Entity("PreKolos2.Entities.FireTruckAction", b =>
                {
                    b.Property<int>("IdFireTruck")
                        .HasColumnType("int");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssignmentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 6, 21, 58, 40, 616, DateTimeKind.Local).AddTicks(5652));

                    b.HasKey("IdFireTruck", "IdAction")
                        .HasName("FireTruckAction_pk");

                    b.HasIndex("IdAction");

                    b.ToTable("FireTruck_Action");

                    b.HasData(
                        new
                        {
                            IdFireTruck = 1,
                            IdAction = 3,
                            AssignmentDate = new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdFireTruck = 2,
                            IdAction = 2,
                            AssignmentDate = new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdFireTruck = 3,
                            IdAction = 1,
                            AssignmentDate = new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PreKolos2.Entities.FireTruckAction", b =>
                {
                    b.HasOne("PreKolos2.Entities.Action", "IdActionNavigation")
                        .WithMany("FireTruckActions")
                        .HasForeignKey("IdAction")
                        .HasConstraintName("FileTruckAction_Action")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PreKolos2.Entities.FireTruck", "IdFireTruckNavigation")
                        .WithMany("FireTruckActions")
                        .HasForeignKey("IdFireTruck")
                        .HasConstraintName("FileTruckAction_FireTruck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdActionNavigation");

                    b.Navigation("IdFireTruckNavigation");
                });

            modelBuilder.Entity("PreKolos2.Entities.Action", b =>
                {
                    b.Navigation("FireTruckActions");
                });

            modelBuilder.Entity("PreKolos2.Entities.FireTruck", b =>
                {
                    b.Navigation("FireTruckActions");
                });
#pragma warning restore 612, 618
        }
    }
}

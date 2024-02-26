﻿// <auto-generated />
using System;
using FitnessTracker.Domain.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessTracker.Domain.Migrations
{
    [DbContext(typeof(SportClubDbContext))]
    partial class SportClubDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessTracker.Domain.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsersIdInBot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.UserSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCheckining")
                        .HasColumnType("bit");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSchedules");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.UserSchedule", b =>
                {
                    b.HasOne("FitnessTracker.Domain.Models.Schedule", "Schedule")
                        .WithMany("UserSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessTracker.Domain.Models.User", "User")
                        .WithMany("UserSchedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Workout", b =>
                {
                    b.HasOne("FitnessTracker.Domain.Models.Schedule", "Schedule")
                        .WithMany("Workouts")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Schedule", b =>
                {
                    b.Navigation("UserSchedules");

                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.User", b =>
                {
                    b.Navigation("UserSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}

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

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
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

                    b.Property<long>("UsersIdInBot")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Visiting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCheckining")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Visitings");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.WorkoutSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("VisitingId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("VisitingId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutSchedules");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Visiting", b =>
                {
                    b.HasOne("FitnessTracker.Domain.Models.User", "User")
                        .WithMany("Visitings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.WorkoutSchedule", b =>
                {
                    b.HasOne("FitnessTracker.Domain.Models.Schedule", "Schedule")
                        .WithMany("WorkoutSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessTracker.Domain.Models.Visiting", null)
                        .WithMany("WorkoutSchedules")
                        .HasForeignKey("VisitingId");

                    b.HasOne("FitnessTracker.Domain.Models.Workout", "Workout")
                        .WithMany("WorkoutSchedules")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Schedule", b =>
                {
                    b.Navigation("WorkoutSchedules");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.User", b =>
                {
                    b.Navigation("Visitings");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Visiting", b =>
                {
                    b.Navigation("WorkoutSchedules");
                });

            modelBuilder.Entity("FitnessTracker.Domain.Models.Workout", b =>
                {
                    b.Navigation("WorkoutSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}

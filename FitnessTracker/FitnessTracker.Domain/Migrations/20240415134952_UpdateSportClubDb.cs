using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSportClubDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSchedules_Visitings_VisitingId",
                table: "WorkoutSchedules");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Schedules",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "Schedules",
                newName: "EndTime");

            migrationBuilder.AlterColumn<int>(
                name: "VisitingId",
                table: "WorkoutSchedules",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Visitings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSchedules_Visitings_VisitingId",
                table: "WorkoutSchedules",
                column: "VisitingId",
                principalTable: "Visitings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSchedules_Visitings_VisitingId",
                table: "WorkoutSchedules");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Visitings");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Schedules",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Schedules",
                newName: "End");

            migrationBuilder.AlterColumn<int>(
                name: "VisitingId",
                table: "WorkoutSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSchedules_Visitings_VisitingId",
                table: "WorkoutSchedules",
                column: "VisitingId",
                principalTable: "Visitings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

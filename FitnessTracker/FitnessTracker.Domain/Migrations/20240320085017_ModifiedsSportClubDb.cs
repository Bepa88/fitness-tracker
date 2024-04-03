using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Domain.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedsSportClubDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VisitingId",
                table: "WorkoutSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "UsersIdInBot",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutSchedules_VisitingId",
                table: "WorkoutSchedules",
                column: "VisitingId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitings_UserId",
                table: "Visitings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitings_Users_UserId",
                table: "Visitings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSchedules_Visitings_VisitingId",
                table: "WorkoutSchedules",
                column: "VisitingId",
                principalTable: "Visitings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitings_Users_UserId",
                table: "Visitings");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSchedules_Visitings_VisitingId",
                table: "WorkoutSchedules");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutSchedules_VisitingId",
                table: "WorkoutSchedules");

            migrationBuilder.DropIndex(
                name: "IX_Visitings_UserId",
                table: "Visitings");

            migrationBuilder.DropColumn(
                name: "VisitingId",
                table: "WorkoutSchedules");

            migrationBuilder.AlterColumn<string>(
                name: "UsersIdInBot",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}

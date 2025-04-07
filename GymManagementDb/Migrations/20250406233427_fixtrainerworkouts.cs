using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementDb.Migrations
{
    /// <inheritdoc />
    public partial class fixtrainerworkouts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Workouts_WorkoutID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Trainers_TrainersTrainerID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_TrainersTrainerID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkoutID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TrainersTrainerID",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Join_Date",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MembershipTpyeID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone_Number",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkoutID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "SpecialtyType",
                table: "TrainerSpecialty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<int>(
                name: "WorkoutsWorkoutID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_TrainerID",
                table: "Workouts",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkoutsWorkoutID",
                table: "AspNetUsers",
                column: "WorkoutsWorkoutID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers",
                column: "MembershipTypeID",
                principalTable: "MembershipType",
                principalColumn: "MembershipTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Workouts_WorkoutsWorkoutID",
                table: "AspNetUsers",
                column: "WorkoutsWorkoutID",
                principalTable: "Workouts",
                principalColumn: "WorkoutID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Trainers_TrainerID",
                table: "Workouts",
                column: "TrainerID",
                principalTable: "Trainers",
                principalColumn: "TrainerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Workouts_WorkoutsWorkoutID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Trainers_TrainerID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_TrainerID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkoutsWorkoutID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SpecialtyType",
                table: "TrainerSpecialty");

            migrationBuilder.DropColumn(
                name: "WorkoutsWorkoutID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "TrainersTrainerID",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Join_Date",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MembershipTpyeID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Phone_Number",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_TrainersTrainerID",
                table: "Workouts",
                column: "TrainersTrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkoutID",
                table: "AspNetUsers",
                column: "WorkoutID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers",
                column: "MembershipTypeID",
                principalTable: "MembershipType",
                principalColumn: "MembershipTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Workouts_WorkoutID",
                table: "AspNetUsers",
                column: "WorkoutID",
                principalTable: "Workouts",
                principalColumn: "WorkoutID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Trainers_TrainersTrainerID",
                table: "Workouts",
                column: "TrainersTrainerID",
                principalTable: "Trainers",
                principalColumn: "TrainerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementDb.Migrations
{
    /// <inheritdoc />
    public partial class fixingresiter2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MembershipTpyeID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers",
                column: "MembershipTypeID",
                principalTable: "MembershipType",
                principalColumn: "MembershipTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MembershipTpyeID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MembershipType_MembershipTypeID",
                table: "AspNetUsers",
                column: "MembershipTypeID",
                principalTable: "MembershipType",
                principalColumn: "MembershipTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

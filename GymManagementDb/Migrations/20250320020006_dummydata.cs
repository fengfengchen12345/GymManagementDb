using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementDb.Migrations
{
    /// <inheritdoc />
    public partial class dummydata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_MembershipType_MembershipTpyeID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MembershipTpyeID",
                table: "Member");

            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeID",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Member_MembershipTypeID",
                table: "Member",
                column: "MembershipTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_MembershipType_MembershipTypeID",
                table: "Member",
                column: "MembershipTypeID",
                principalTable: "MembershipType",
                principalColumn: "MembershipTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_MembershipType_MembershipTypeID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MembershipTypeID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MembershipTypeID",
                table: "Member");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MembershipTpyeID",
                table: "Member",
                column: "MembershipTpyeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_MembershipType_MembershipTpyeID",
                table: "Member",
                column: "MembershipTpyeID",
                principalTable: "MembershipType",
                principalColumn: "MembershipTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

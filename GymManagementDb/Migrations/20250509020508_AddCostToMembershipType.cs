using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementDb.Migrations
{
    /// <inheritdoc />
    public partial class AddCostToMembershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "MembershipType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "MembershipType");
        }
    }
}

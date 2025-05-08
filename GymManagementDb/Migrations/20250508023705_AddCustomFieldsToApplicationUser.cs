using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementDb.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomFieldsToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "AspNetUsers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Last_Name",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "First_Name",
                table: "AspNetUsers",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "AspNetUsers",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Last_Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "First_Name");
        }
    }
}

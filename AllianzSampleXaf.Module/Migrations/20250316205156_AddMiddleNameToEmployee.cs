using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllianzSampleXaf.Module.Migrations
{
    /// <inheritdoc />
    public partial class AddMiddleNameToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Employees",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Employees");
        }
    }
}

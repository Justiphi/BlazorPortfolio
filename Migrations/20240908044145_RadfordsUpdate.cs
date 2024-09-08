using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class RadfordsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 6,
                column: "EndYear",
                value: 2024);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 6,
                column: "EndYear",
                value: null);
        }
    }
}

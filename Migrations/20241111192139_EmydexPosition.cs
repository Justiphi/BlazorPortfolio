using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class EmydexPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ExperienceId", "Company", "EndYear", "Framework", "Languages", "SoftwareBased", "StartYear", "Title" },
                values: new object[] { 7, "Emydex Technology", null, "Windows Forms", "C#, SQL", true, 2024, "Solution Engineer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 7);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class ExperienceUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 3,
                columns: new[] { "Languages", "Title" },
                values: new object[] { "JavaScript, HTML, CSS", "Developer" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ExperienceId", "Company", "EndYear", "Framework", "Languages", "SoftwareBased", "StartYear", "Title" },
                values: new object[] { 6, "Radfords", null, "Windows Forms, Xamarin, WPF, Blazor, MAUI", "C#, VB.net, SQL", true, 2020, "Full Stack Developer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 3,
                columns: new[] { "Languages", "Title" },
                values: new object[] { "JavaScript", "Junior Developer" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ExperienceId", "Company", "EndYear", "Framework", "Languages", "SoftwareBased", "StartYear", "Title" },
                values: new object[,]
                {
                    { 1, "Radfords", null, "Windows Forms, Xamarin, WPF, Blazor, MAUI", "C#, VB.net, SQL", true, 2022, "Developer" },
                    { 2, "Radfords", 2022, "Windows Forms, Xamarin, WPF", "C#, VB.net, SQL", true, 2020, "Junior Developer" }
                });
        }
    }
}

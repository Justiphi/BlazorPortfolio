using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class AddHaSCert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 1,
                column: "Framework",
                value: "Windows Forms, Xamarin, WPF, Blazor, MAUI");

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "QualificationId", "Location", "Title", "Year" },
                values: new object[] { 6, "EMA+", "Certificate in Health and Safety Representation (Level 3)", 2020 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "QualificationId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 1,
                column: "Framework",
                value: "Windows Forms, Blazor, MAUI, Xamarin, WPF");
        }
    }
}

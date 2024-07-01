using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "Description", "Framework" },
                values: new object[] { "Previous web portfolio", "ASP.net, React" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "Description",
                value: "Code for pip boy prop");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "Description", "Framework" },
                values: new object[] { "Azure based Voice Assistant (superseded by ADA-MKII)", "WPF, Avalonia" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Framework", "GithubLink", "Languages", "Title" },
                values: new object[,]
                {
                    { 6, "MTG dice and coin generator used for tutoring programming", "MAUI", "https://github.com/Justiphi/DiceApp", "C#", "Dice & Coins" },
                    { 7, "Voice Assistant", "MAUI", "https://github.com/Justiphi/ADA-MKII", "C#", "ADA-MKII" },
                    { 8, "Proof of concept Computer Vision application", "WPF", "https://github.com/Justiphi/peoplecounter", "C#", "People Counter" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "Description", "Framework" },
                values: new object[] { "previous web portfolio", "ASP.net, ASP.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "Description",
                value: "Code for Prop");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "Description", "Framework" },
                values: new object[] { "Azure based Voice Assistant", "WPF" });
        }
    }
}

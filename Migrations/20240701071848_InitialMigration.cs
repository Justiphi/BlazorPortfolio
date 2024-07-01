using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Framework = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ExperienceId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Languages = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Framework = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GithubLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.QualificationId);
                });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ExperienceId", "Company", "EndYear", "Framework", "Languages", "StartYear", "Title" },
                values: new object[,]
                {
                    { 1, "Radfords", null, "Windows Forms, Xamarin, WPF, Blazor, MAUI", "C#, VB.net, SQL", 2022, "Developer" },
                    { 2, "Radfords", 2022, "Windows Forms, Xamarin, WPF", "C#, VB.net, SQL", 2020, "Junior Developer" },
                    { 3, "Cucumber", 2019, "", "JavaScript", 2019, "Junior Developer" },
                    { 4, "The Raft", 2020, "N/A", "N/A", 2016, "Kitchen Hand" },
                    { 5, "Bay of Plenty Times", 2013, "N/A", "N/A", 2009, "Paper Deliverer" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Framework", "GithubLink", "Languages", "Title" },
                values: new object[,]
                {
                    { 1, "Current web portfolio", "Blazor", "https://github.com/Justiphi/BlazorPortfolio", "C#", "Blazor Portfolio" },
                    { 2, "previous web portfolio", "ASP.net, ASP.net", "https://github.com/Justiphi/Travis-CV", "C#, TypeScript", "Web Portfolio" },
                    { 3, "Discord Bot", "Dotnet Core", "https://github.com/Justiphi/Tatenashi", "C#", "Tatenashi" },
                    { 4, "Code for Prop", "PyGame", "https://github.com/Justiphi/pipboy", "Python", "Pip Boy" },
                    { 5, "Azure based Voice Assistant", "WPF", "https://github.com/Justiphi/Project-RIANTI", "C#", "Project RIANTI" }
                });

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "QualificationId", "Location", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Otumoetai College", "NCEA Level 3", 2016 },
                    { 2, "Toi Ohomai", "Diploma in Applied Computing (Level 5 with distinction)", 2017 },
                    { 3, "Toi Ohomai", "Skills for Entrepeneurs (Level 7)", 2018 },
                    { 4, "Toi Ohomai", "Diploma in Software Development (Level 6)", 2018 },
                    { 5, "University of Waikato", "Bachelors of Science, Major in Applied Computing", 2019 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Qualifications");
        }
    }
}

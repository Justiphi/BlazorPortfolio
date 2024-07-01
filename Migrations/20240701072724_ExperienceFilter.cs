using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class ExperienceFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SoftwareBased",
                table: "Experience",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 1,
                column: "SoftwareBased",
                value: true);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 2,
                column: "SoftwareBased",
                value: true);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 3,
                columns: new[] { "Framework", "SoftwareBased" },
                values: new object[] { "jQuery", true });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 4,
                column: "SoftwareBased",
                value: false);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 5,
                column: "SoftwareBased",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftwareBased",
                table: "Experience");

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "ExperienceId",
                keyValue: 3,
                column: "Framework",
                value: "");
        }
    }
}

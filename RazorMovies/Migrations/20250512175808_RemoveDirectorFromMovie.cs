using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorMovies.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDirectorFromMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _MVCPelicula_.Migrations
{
    /// <inheritdoc />
    public partial class Pelicula_Col_Director : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sala",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Sala",
                table: "Peliculas");
        }
    }
}

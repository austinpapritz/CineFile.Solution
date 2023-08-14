using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineFile.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Genre",
                value: "Childrens");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Action", "Ironman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Romance", "Edward Scissorhands" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Childrens", "Pippy Longstocking" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Action", "John Wick 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Genre",
                value: "Woolly Mammoth");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Dinosaur", "Rexie" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Dinosaur", "Matilda" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Shark", "Pip" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Dinosaur", "Bartholomew" });
        }
    }
}

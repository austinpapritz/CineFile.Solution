using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineFile.Migrations
{
    public partial class SeededUsersAndComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pasword = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DatePosted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Pasword", "Username" },
                values: new object[,]
                {
                    { 1, "password123", "User1" },
                    { 2, "password123", "User2" },
                    { 3, "password123", "User3" },
                    { 4, "password123", "User4" },
                    { 5, "password123", "User5" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "DatePosted", "MovieId", "UserId" },
                values: new object[,]
                {
                    { 1, "User1's comment on Matilda", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7332), 1, 1 },
                    { 2, "User1's comment on Ironman", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7365), 2, 1 },
                    { 3, "User1's comment on Edward Scissorhands", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7368), 3, 1 },
                    { 4, "User1's comment on Pippy Longstocking", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7370), 4, 1 },
                    { 5, "User1's comment on John Wick 2", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7372), 5, 1 },
                    { 6, "User2's comment on Matilda", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7375), 1, 2 },
                    { 7, "User2's comment on Ironman", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7377), 2, 2 },
                    { 8, "User2's comment on Edward Scissorhands", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7379), 3, 2 },
                    { 9, "User2's comment on Pippy Longstocking", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7381), 4, 2 },
                    { 10, "User2's comment on John Wick 2", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7383), 5, 2 },
                    { 11, "User3's comment on Matilda", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7385), 1, 3 },
                    { 12, "User3's comment on Ironman", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7387), 2, 3 },
                    { 13, "User3's comment on Edward Scissorhands", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7389), 3, 3 },
                    { 14, "User3's comment on Pippy Longstocking", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7392), 4, 3 },
                    { 15, "User3's comment on John Wick 3", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7394), 5, 3 },
                    { 16, "User4's comment on Matilda", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7396), 1, 4 },
                    { 17, "User4's comment on Ironman", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7398), 2, 4 },
                    { 18, "User4's comment on Edward Scissorhands", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7400), 3, 4 },
                    { 19, "User4's comment on Pippy Longstocking", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7402), 4, 4 },
                    { 20, "User4's comment on John Wick 2", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7404), 5, 4 },
                    { 21, "User5's comment on Matilda", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7406), 1, 5 },
                    { 22, "User5's comment on Ironman", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7409), 2, 5 },
                    { 23, "User5's comment on Edward Scissorhands", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7411), 3, 5 },
                    { 24, "User5's comment on Pippy Longstocking", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7413), 4, 5 },
                    { 25, "User5's comment on John Wick 2", new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7415), 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

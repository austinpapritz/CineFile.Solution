using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineFile.Migrations
{
    public partial class PasswordTwoS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pasword",
                table: "Users",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25,
                column: "DatePosted",
                value: new DateTime(2023, 8, 16, 9, 2, 22, 972, DateTimeKind.Local).AddTicks(7492));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Pasword");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25,
                column: "DatePosted",
                value: new DateTime(2023, 8, 15, 11, 36, 18, 519, DateTimeKind.Local).AddTicks(7415));
        }
    }
}

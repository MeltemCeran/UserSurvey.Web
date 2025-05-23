using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserInsightSurvey.Migrations
{
    /// <inheritdoc />
    public partial class QuestionTableSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionType",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Created", "Deleted", "MultipleChoice", "QuestionType", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "C# dilinde en çok kullandığınız özellik nedir?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7286), null, false, 0, null },
                    { 2, ".NET teknolojilerinden hangileriyle çalıştınız?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7304), null, true, 2, null },
                    { 3, "En çok kullandığınız IDE hangisidir?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7305), null, true, 1, null },
                    { 4, "Entity Framework ile ilgili deneyiminizi kısaca anlatır mısınız?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7306), null, false, 0, null },
                    { 5, "Aşağıdaki mimari desenlerden hangilerini projelerinizde kullandınız?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7308), null, true, 2, null },
                    { 6, ".NET Core ile .NET Framework arasındaki temel fark nedir?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7309), null, false, 0, null },
                    { 7, "Hangi veritabanı sistemleriyle çalıştınız?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7310), null, true, 2, null },
                    { 8, "Bir web API projesinde en önemli gördüğünüz güvenlik önlemi nedir?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7311), null, false, 0, null },
                    { 9, "Aşağıdaki bulut servislerinden hangilerini kullandınız?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7312), null, true, 2, null },
                    { 10, "Yazılım geliştirme sürecinde en çok hangi aşamada zorlanıyorsunuz?", new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7313), null, true, 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Questions");
        }
    }
}

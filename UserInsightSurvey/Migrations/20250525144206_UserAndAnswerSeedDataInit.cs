using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserInsightSurvey.Migrations
{
    /// <inheritdoc />
    public partial class UserAndAnswerSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b777b6f2-5ae3-4497-a2d9-f0ebb7caa004", "AQAAAAIAAYagAAAAEJ9CXtfC6qm8bBQcnGEs/EqvfzgVf0H6Q1505j6h3ch0e9ERYlC9j6L/Nicemnukzw==", "f90acaea-ce0c-4ce3-8954-02448fc11ddb" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CvFilePath", "Deleted", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "11111111-aaaa-bbbb-cccc-111111111111", 0, "ae81940d-2a14-478d-9eb7-bba88e302717", "", null, "ali.vural@example.com", true, false, null, "Ali", "ALI.VURAL@EXAMPLE.COM", "ALI.VURAL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDcGDdS9WhsjKNmIvMJkv4LJ3p1jxU7mzSNiauH+71aUpk61+np8KZdwNZ1GO8blUg==", null, false, "80cf340d-3545-44a4-97d0-cf4e13b164f3", "Vural", false, "ali.vural@example.com", 1 },
                    { "22222222-aaaa-bbbb-cccc-222222222222", 0, "aef3f959-d3bd-4442-9026-2c5fafa5c970", "", null, "zeynep.demir@example.com", true, false, null, "Zeynep", "ZEYNEP.DEMIR@EXAMPLE.COM", "ZEYNEP.DEMIR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJOsc3+rChRgKPHh4z+47rndtHk0EGpzP5REob+dXs3g2JMV3n89pdBKrh8MfnljIA==", null, false, "6516d8c7-64f0-4e61-881e-76d5c32fcb63", "Demir", false, "zeynep.demir@example.com", 1 },
                    { "33333333-aaaa-bbbb-cccc-333333333333", 0, "8f256dde-f468-442c-8b97-429643202094", "", null, "mehmet.kaya@example.com", true, false, null, "Mehmet", "MEHMET.KAYA@EXAMPLE.COM", "MEHMET.KAYA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIOzYXtPLGEwMW0seZlj0YoohAW7AmZHpZa56Ei+ULc5YRofX5n+LOM0YoNrkt3uCA==", null, false, "ea53bf28-c409-4a5c-8053-8576d238176a", "Kaya", false, "mehmet.kaya@example.com", 1 },
                    { "99999999-aaaa-bbbb-cccc-999999999999", 0, "8a74572d-aae7-48c7-991d-e81d6bb7638a", "", null, "admin@demo.com", true, false, null, "Admin", "ADMIN@DEMO.COM", "ADMIN@DEMO.COM", "AQAAAAIAAYagAAAAEMoJyJmozkFVHZEzU6G7tM8n/hZ2KUrL9W7ugKivMVKKPfS28LLZ9/NHmMJ6a4cL5Q==", null, false, "da852466-6c9a-43c2-8782-226b0c15612f", "Yönetici", false, "admin@demo.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "OptionId", "QuestionId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 101, "Delegates ve Events", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 102, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 103, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 2, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 104, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 3, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 105, "Migration ve Code First tecrübem var.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 106, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 5, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 107, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, 5, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 108, ".NET Core platform bağımsızdır.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 6, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 109, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, 7, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 110, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, 7, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 111, "JWT ile kimlik doğrulama kullanırım.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 8, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 112, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, 9, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 113, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, 10, null, "11111111-aaaa-bbbb-cccc-111111111111" },
                    { 201, "LINQ ve Lambda Expressions", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 202, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 203, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 2, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 204, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 3, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 205, "Database First ile çalıştım.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 206, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 5, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 207, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 5, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 208, ".NET Core açık kaynaklıdır.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 6, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 209, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, 7, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 210, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, 7, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 211, "OAuth2 ile güvenlik sağlarım.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 8, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 212, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, 9, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 213, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, 10, null, "22222222-aaaa-bbbb-cccc-222222222222" },
                    { 301, "Async/Await kullanımı", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 302, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 303, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 304, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 3, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 305, "EF Core ile performans optimizasyonu yaptım.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 306, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 5, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 307, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 5, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 308, ".NET Core hızlıdır.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 6, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 309, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, 7, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 310, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, 7, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 311, "HTTPS zorunlu kullanırım.", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 8, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 312, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, 9, null, "33333333-aaaa-bbbb-cccc-333333333333" },
                    { 313, null, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 10, null, "33333333-aaaa-bbbb-cccc-333333333333" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-aaaa-bbbb-cccc-999999999999");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-aaaa-bbbb-cccc-111111111111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-aaaa-bbbb-cccc-222222222222");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-aaaa-bbbb-cccc-333333333333");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "947985a8-d1e5-4590-834d-04815b37fab9", "AQAAAAIAAYagAAAAEAB4tXFUNQ2vPuI7aRQcF+PWFEcIEWnK82G/21AdTHUfexcSvuuU1mp14q+IbX4PVw==", "9eb17d9c-9ad6-45b8-a240-486e2479c05e" });
        }
    }
}

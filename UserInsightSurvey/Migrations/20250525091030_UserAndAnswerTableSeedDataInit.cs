using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserInsightSurvey.Migrations
{
    /// <inheritdoc />
    public partial class UserAndAnswerTableSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CvFilePath", "Deleted", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "252d1809-cd07-4ebd-87d1-83cefac3b78c", 0, "00bf48aa-21e6-4b81-9e8d-f26179a02769", "", null, "test@demo.com", true, false, null, "Test", "TEST@DEMO.COM", "TEST@DEMO.COM", "AQAAAAIAAYagAAAAEA/pjxfX1d4MJZwROT5hrv3ouVkl1ThceIXSKNpG8X/Q5aLIEv0gDW7gMfaEgvOl2w==", null, false, "3d9ca5ed-0808-4773-9562-d52466480b04", "Kullanıcı", false, "test@demo.com", 1 });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "OptionId", "QuestionId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, "LINQ", new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(680), null, null, 1, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 2, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(704), null, 1, 2, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 3, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(706), null, 3, 2, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 4, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(707), null, 5, 3, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 5, "Code First ile migration yönetimi deneyimim var.", new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(708), null, null, 4, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 6, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(710), null, 9, 5, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 7, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(711), null, 12, 5, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 8, ".NET Core platform bağımsızdır.", new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(712), null, null, 6, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 9, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(713), null, 13, 7, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 10, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(715), null, 16, 7, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 11, "JWT ile kimlik doğrulama kullanırım.", new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(716), null, null, 8, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 12, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(718), null, 17, 9, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { 13, null, new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(719), null, 23, 10, null, "252d1809-cd07-4ebd-87d1-83cefac3b78c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 9, 52, 136, DateTimeKind.Local).AddTicks(2662));
        }
    }
}

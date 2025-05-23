using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserInsightSurvey.Migrations
{
    /// <inheritdoc />
    public partial class OptionTableSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Content", "Created", "Deleted", "QuestionId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "ASP.NET Core", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4401), null, 2, null },
                    { 2, "WinForms", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4406), null, 2, null },
                    { 3, "WPF", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4407), null, 2, null },
                    { 4, "Blazor", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4408), null, 2, null },
                    { 5, "Visual Studio", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4409), null, 3, null },
                    { 6, "Rider", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4410), null, 3, null },
                    { 7, "VS Code", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4411), null, 3, null },
                    { 8, "Diğer", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4412), null, 3, null },
                    { 9, "MVC", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4413), null, 5, null },
                    { 10, "MVVM", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4414), null, 5, null },
                    { 11, "Onion Architecture", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4415), null, 5, null },
                    { 12, "Clean Architecture", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4416), null, 5, null },
                    { 13, "SQL Server", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4417), null, 7, null },
                    { 14, "PostgreSQL", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4418), null, 7, null },
                    { 15, "MySQL", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4419), null, 7, null },
                    { 16, "MongoDB", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4420), null, 7, null },
                    { 17, "Azure", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4420), null, 9, null },
                    { 18, "AWS", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4421), null, 9, null },
                    { 19, "Google Cloud", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4422), null, 9, null },
                    { 20, "Hiçbiri", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4423), null, 9, null },
                    { 21, "Analiz", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4424), null, 10, null },
                    { 22, "Tasarım", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4425), null, 10, null },
                    { 23, "Kodlama", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4426), null, 10, null },
                    { 24, "Test", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4427), null, 10, null },
                    { 25, "Bakım", new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4428), null, 10, null }
                });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 22, 6, 383, DateTimeKind.Local).AddTicks(4147));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 18, 34, 646, DateTimeKind.Local).AddTicks(8332));
        }
    }
}

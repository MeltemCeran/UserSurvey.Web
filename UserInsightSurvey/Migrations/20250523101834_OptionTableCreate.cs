using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserInsightSurvey.Migrations
{
    /// <inheritdoc />
    public partial class OptionTableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OptionId",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "Answers");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2025, 5, 23, 13, 9, 47, 177, DateTimeKind.Local).AddTicks(7313));
        }
    }
}

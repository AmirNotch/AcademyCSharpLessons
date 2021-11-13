using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyCSharpLesson02._11._2021.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuotesCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotesCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuotesModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    QuotesCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotesModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuotesModels_QuotesCategories_QuotesCategoryId",
                        column: x => x.QuotesCategoryId,
                        principalTable: "QuotesCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "QuotesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Бизнес" });

            migrationBuilder.InsertData(
                table: "QuotesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Продуктивность" });

            migrationBuilder.InsertData(
                table: "QuotesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Шуточные" });

            migrationBuilder.InsertData(
                table: "QuotesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Жизненные" });

            migrationBuilder.InsertData(
                table: "QuotesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Рабочие" });

            migrationBuilder.CreateIndex(
                name: "IX_QuotesModels_QuotesCategoryId",
                table: "QuotesModels",
                column: "QuotesCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuotesModels");

            migrationBuilder.DropTable(
                name: "QuotesCategories");
        }
    }
}

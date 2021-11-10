using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductStoreMVC.Migrations
{
    public partial class addSqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Product = table.Column<string>(type: "TEXT", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StoreCompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_StoreCompanies_StoreCompanyId",
                        column: x => x.StoreCompanyId,
                        principalTable: "StoreCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StoreCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Овощи" });

            migrationBuilder.InsertData(
                table: "StoreCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Фрукты" });

            migrationBuilder.InsertData(
                table: "StoreCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Хлеб" });

            migrationBuilder.InsertData(
                table: "StoreCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Молочные продукты" });

            migrationBuilder.CreateIndex(
                name: "IX_Stores_StoreCompanyId",
                table: "Stores",
                column: "StoreCompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "StoreCompanies");
        }
    }
}

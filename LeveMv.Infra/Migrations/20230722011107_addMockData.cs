using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class addMockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ID",
                keyValue: new Guid("afc849df-735d-48ec-8e20-61aa2e434cff"),
                column: "Quantidade",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ID",
                keyValue: new Guid("c9939d1c-dbd8-4215-9bb7-5ef4e17b9743"),
                columns: new[] { "Nome", "Preco", "Quantidade" },
                values: new object[] { "Cabo Grosso", 10.5m, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ID",
                keyValue: new Guid("afc849df-735d-48ec-8e20-61aa2e434cff"),
                column: "Quantidade",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ID",
                keyValue: new Guid("c9939d1c-dbd8-4215-9bb7-5ef4e17b9743"),
                columns: new[] { "Nome", "Preco", "Quantidade" },
                values: new object[] { "Cabo Tipo C", 22.5m, 0 });
        }
    }
}

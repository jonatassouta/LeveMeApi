using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertdeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeveMvID",
                table: "Clientes");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ID", "Ativo", "Cidade", "DataCadastro", "Endereço", "Nome", "Telefone", "UF" },
                values: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), true, "Araraquaa", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Av. Teste", "Jonatas", "16999998888", "SP" });

            migrationBuilder.InsertData(
                table: "LeveMe",
                columns: new[] { "ID", "Nome" },
                values: new object[] { new Guid("fa974954-c32d-4e62-9154-c77d14445525"), "Leve Me Tipo 1" });

            migrationBuilder.InsertData(
                table: "ClientesleveMe",
                columns: new[] { "ClienteId", "LeveMeId" },
                values: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), new Guid("fa974954-c32d-4e62-9154-c77d14445525") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientesleveMe",
                keyColumns: new[] { "ClienteId", "LeveMeId" },
                keyValues: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), new Guid("fa974954-c32d-4e62-9154-c77d14445525") });

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ID",
                keyValue: new Guid("6714d050-cbad-4951-b819-3641e4647f1c"));

            migrationBuilder.DeleteData(
                table: "LeveMe",
                keyColumn: "ID",
                keyValue: new Guid("fa974954-c32d-4e62-9154-c77d14445525"));

            migrationBuilder.AddColumn<Guid>(
                name: "LeveMvID",
                table: "Clientes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}

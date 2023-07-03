using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTabelasBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesleveMe_LeveMe_LeveMeId",
                table: "ClientesleveMe");

            migrationBuilder.DropTable(
                name: "LeveMe");

            migrationBuilder.RenameColumn(
                name: "LeveMeId",
                table: "ClientesleveMe",
                newName: "LeveMvId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesleveMe_LeveMeId",
                table: "ClientesleveMe",
                newName: "IX_ClientesleveMe_LeveMvId");

            migrationBuilder.CreateTable(
                name: "LeveMv",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeveMv", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "LeveMv",
                columns: new[] { "ID", "Nome" },
                values: new object[] { new Guid("fa974954-c32d-4e62-9154-c77d14445525"), "Leve Me Tipo 1" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesleveMe_LeveMv_LeveMvId",
                table: "ClientesleveMe",
                column: "LeveMvId",
                principalTable: "LeveMv",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesleveMe_LeveMv_LeveMvId",
                table: "ClientesleveMe");

            migrationBuilder.DropTable(
                name: "LeveMv");

            migrationBuilder.RenameColumn(
                name: "LeveMvId",
                table: "ClientesleveMe",
                newName: "LeveMeId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesleveMe_LeveMvId",
                table: "ClientesleveMe",
                newName: "IX_ClientesleveMe_LeveMeId");

            migrationBuilder.CreateTable(
                name: "LeveMe",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeveMe", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "LeveMe",
                columns: new[] { "ID", "Nome" },
                values: new object[] { new Guid("fa974954-c32d-4e62-9154-c77d14445525"), "Leve Me Tipo 1" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesleveMe_LeveMe_LeveMeId",
                table: "ClientesleveMe",
                column: "LeveMeId",
                principalTable: "LeveMe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

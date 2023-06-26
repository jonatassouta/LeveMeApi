using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Endereço = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(20)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(38,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClientesleveMe",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeveMeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesleveMe", x => new { x.ClienteId, x.LeveMeId });
                    table.ForeignKey(
                        name: "FK_ClientesleveMe_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesleveMe_LeveMe_LeveMeId",
                        column: x => x.LeveMeId,
                        principalTable: "LeveMe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ClientesleveMe_LeveMeId",
                table: "ClientesleveMe",
                column: "LeveMeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesleveMe");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "LeveMe");
        }
    }
}

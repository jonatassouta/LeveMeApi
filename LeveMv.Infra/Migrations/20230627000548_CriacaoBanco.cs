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
                    CNPJ = table.Column<decimal>(type: "numeric(14,0)", nullable: false),
                    Endereço = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(20)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "varchar(40)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
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
                    Preco = table.Column<decimal>(type: "numeric(38,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produtos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "ID", "Ativo", "Bairro", "CNPJ", "Cidade", "DataCadastro", "Email", "Endereço", "Nome", "Telefone", "UF" },
                values: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), true, "Vila Xavier", 11122233345678m, "Araraquara", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Av. Teste", "Jonatas", "16999998888", "SP" });

            migrationBuilder.InsertData(
                table: "LeveMe",
                columns: new[] { "ID", "Nome" },
                values: new object[] { new Guid("fa974954-c32d-4e62-9154-c77d14445525"), "Leve Me Tipo 1" });

            migrationBuilder.InsertData(
                table: "ClientesleveMe",
                columns: new[] { "ClienteId", "LeveMeId" },
                values: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), new Guid("fa974954-c32d-4e62-9154-c77d14445525") });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ID", "ClienteId", "Nome", "Preco", "Quantidade" },
                values: new object[] { new Guid("afc849df-735d-48ec-8e20-61aa2e434cff"), new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), "Cabo Tipo C", 22.5m, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ClientesleveMe_LeveMeId",
                table: "ClientesleveMe",
                column: "LeveMeId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesleveMe");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "LeveMe");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

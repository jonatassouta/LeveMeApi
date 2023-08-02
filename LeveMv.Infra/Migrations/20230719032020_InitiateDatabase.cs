using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitiateDatabase : Migration
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
                    CNPJ = table.Column<decimal>(type: "numeric(14,0)", precision: 14, scale: 0, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(20)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "varchar(40)", nullable: true),
                    Senha = table.Column<string>(type: "varchar(8)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    LeveMvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Perfil = table.Column<string>(type: "varchar(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

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
                name: "ClienteleveMv",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeveMvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteleveMv", x => new { x.ClienteId, x.LeveMvId });
                    table.ForeignKey(
                        name: "FK_ClienteleveMv_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteleveMv_LeveMv_LeveMvId",
                        column: x => x.LeveMvId,
                        principalTable: "LeveMv",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ID", "Ativo", "Bairro", "CNPJ", "Cidade", "DataCadastro", "Email", "Endereco", "LeveMvId", "Nome", "Perfil", "Senha", "Telefone", "UF" },
                values: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), true, "Vila Xavier", 11122233345678m, "Araraquara", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Av. Teste", new Guid("00000000-0000-0000-0000-000000000000"), "Jonatas", "Admin", "123456", "16999998888", "SP" });

            migrationBuilder.InsertData(
                table: "LeveMv",
                columns: new[] { "ID", "Nome" },
                values: new object[] { new Guid("fa974954-c32d-4e62-9154-c77d14445525"), "Leve Me Tipo 1" });

            migrationBuilder.InsertData(
                table: "ClienteleveMv",
                columns: new[] { "ClienteId", "LeveMvId" },
                values: new object[] { new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), new Guid("fa974954-c32d-4e62-9154-c77d14445525") });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ID", "ClienteId", "Nome", "Preco", "Quantidade" },
                values: new object[] { new Guid("afc849df-735d-48ec-8e20-61aa2e434cff"), new Guid("6714d050-cbad-4951-b819-3641e4647f1c"), "Cabo Tipo C", 22.5m, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteleveMv_LeveMvId",
                table: "ClienteleveMv",
                column: "LeveMvId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteleveMv");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "LeveMv");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

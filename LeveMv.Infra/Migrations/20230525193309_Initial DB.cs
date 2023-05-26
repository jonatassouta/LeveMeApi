using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMv.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    LeveMvID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LeveMvs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClientesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeveMvs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LeveMvs_Clientes_ClientesID",
                        column: x => x.ClientesID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LeveMvID",
                table: "Clientes",
                column: "LeveMvID");

            migrationBuilder.CreateIndex(
                name: "IX_LeveMvs_ClientesID",
                table: "LeveMvs",
                column: "ClientesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_LeveMvs_LeveMvID",
                table: "Clientes",
                column: "LeveMvID",
                principalTable: "LeveMvs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_LeveMvs_LeveMvID",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "LeveMvs");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTabelasClienteLeveMv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesleveMe_Clientes_ClienteId",
                table: "ClientesleveMe");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientesleveMe_LeveMv_LeveMvId",
                table: "ClientesleveMe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientesleveMe",
                table: "ClientesleveMe");

            migrationBuilder.RenameTable(
                name: "ClientesleveMe",
                newName: "ClienteleveMv");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesleveMe_LeveMvId",
                table: "ClienteleveMv",
                newName: "IX_ClienteleveMv_LeveMvId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClienteleveMv",
                table: "ClienteleveMv",
                columns: new[] { "ClienteId", "LeveMvId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteleveMv_Clientes_ClienteId",
                table: "ClienteleveMv",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteleveMv_LeveMv_LeveMvId",
                table: "ClienteleveMv",
                column: "LeveMvId",
                principalTable: "LeveMv",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteleveMv_Clientes_ClienteId",
                table: "ClienteleveMv");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteleveMv_LeveMv_LeveMvId",
                table: "ClienteleveMv");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClienteleveMv",
                table: "ClienteleveMv");

            migrationBuilder.RenameTable(
                name: "ClienteleveMv",
                newName: "ClientesleveMe");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteleveMv_LeveMvId",
                table: "ClientesleveMe",
                newName: "IX_ClientesleveMe_LeveMvId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientesleveMe",
                table: "ClientesleveMe",
                columns: new[] { "ClienteId", "LeveMvId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesleveMe_Clientes_ClienteId",
                table: "ClientesleveMe",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesleveMe_LeveMv_LeveMvId",
                table: "ClientesleveMe",
                column: "LeveMvId",
                principalTable: "LeveMv",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

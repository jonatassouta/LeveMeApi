using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeveMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPerfilSenhaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "Clientes",
                type: "varchar(8)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ID",
                keyValue: new Guid("6714d050-cbad-4951-b819-3641e4647f1c"),
                column: "Perfil",
                value: "Admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Perfil",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(8)");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ID",
                keyValue: new Guid("6714d050-cbad-4951-b819-3641e4647f1c"),
                column: "Perfil",
                value: 0);
        }
    }
}

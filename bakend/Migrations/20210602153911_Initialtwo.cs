using Microsoft.EntityFrameworkCore.Migrations;

namespace bakend.Migrations
{
    public partial class Initialtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "posiciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_posiciones_UsuarioId",
                table: "posiciones",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_posiciones_Usuario_UsuarioId",
                table: "posiciones",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Usuarioid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posiciones_Usuario_UsuarioId",
                table: "posiciones");

            migrationBuilder.DropIndex(
                name: "IX_posiciones_UsuarioId",
                table: "posiciones");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "posiciones");
        }
    }
}

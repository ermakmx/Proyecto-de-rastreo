using Microsoft.EntityFrameworkCore.Migrations;

namespace bakend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "posiciones",
                columns: table => new
                {
                    PosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecursoId = table.Column<int>(type: "int", nullable: false),
                    latitud = table.Column<double>(type: "float", nullable: false),
                    longitud = table.Column<double>(type: "float", nullable: false),
                    FStamp = table.Column<byte>(type: "tinyint", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posiciones", x => x.PosId);
                    table.ForeignKey(
                        name: "FK_posiciones_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "RecursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_posiciones_RecursoId",
                table: "posiciones",
                column: "RecursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "posiciones");
        }
    }
}

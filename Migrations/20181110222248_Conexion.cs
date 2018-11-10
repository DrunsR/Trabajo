using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabajo.Migrations
{
    public partial class Conexion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InicioR",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Usuario = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InicioR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InicioRId = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    telefono = table.Column<int>(nullable: false),
                    direccion = table.Column<string>(nullable: false),
                    RUC = table.Column<string>(nullable: false),
                    confirm_password = table.Column<string>(nullable: false),
                    nombreTienda = table.Column<string>(nullable: false),
                    foto = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurante_InicioR_InicioRId",
                        column: x => x.InicioRId,
                        principalTable: "InicioR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurante_InicioRId",
                table: "Restaurante",
                column: "InicioRId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurante");

            migrationBuilder.DropTable(
                name: "InicioR");
        }
    }
}

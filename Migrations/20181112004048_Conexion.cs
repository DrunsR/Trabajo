using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabajo.Migrations
{
    public partial class Conexion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    Usuario = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: false),
                    telefono = table.Column<int>(nullable: false),
                    direccion = table.Column<string>(nullable: false),
                    RUC = table.Column<string>(nullable: false),
                    Ini_Contraseña = table.Column<string>(nullable: false),
                    confirm_password = table.Column<string>(nullable: false),
                    nombreTienda = table.Column<string>(nullable: false),
                    foto = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InicioR",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Usuario = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    regId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InicioR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InicioR_Restaurante_regId",
                        column: x => x.regId,
                        principalTable: "Restaurante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Precio = table.Column<int>(nullable: false),
                    Imagen = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    regId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroMenus_Restaurante_regId",
                        column: x => x.regId,
                        principalTable: "Restaurante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InicioR_regId",
                table: "InicioR",
                column: "regId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroMenus_regId",
                table: "RegistroMenus",
                column: "regId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InicioR");

            migrationBuilder.DropTable(
                name: "RegistroMenus");

            migrationBuilder.DropTable(
                name: "Restaurante");
        }
    }
}

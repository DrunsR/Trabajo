using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabajo.Migrations
{
    public partial class ConexionAndTablas : Migration
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
                    email = table.Column<string>(nullable: false),
                    telefono = table.Column<int>(nullable: false),
                    direccion = table.Column<string>(nullable: false),
                    RUC = table.Column<string>(nullable: false),
                    confirm_password = table.Column<string>(nullable: false),
                    nombreTienda = table.Column<string>(nullable: false),
                    foto = table.Column<string>(nullable: true),
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
                    RestauranteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InicioR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InicioR_Restaurante_RestauranteId",
                        column: x => x.RestauranteId,
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

            migrationBuilder.CreateTable(
                name: "Sugerencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    asunto = table.Column<string>(nullable: true),
                    RestId = table.Column<int>(nullable: true),
                    RegistroRestId = table.Column<int>(nullable: false),
                    detalle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sugerencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sugerencia_Restaurante_RestId",
                        column: x => x.RestId,
                        principalTable: "Restaurante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InicioR_RestauranteId",
                table: "InicioR",
                column: "RestauranteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistroMenus_regId",
                table: "RegistroMenus",
                column: "regId");

            migrationBuilder.CreateIndex(
                name: "IX_Sugerencia_RestId",
                table: "Sugerencia",
                column: "RestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InicioR");

            migrationBuilder.DropTable(
                name: "RegistroMenus");

            migrationBuilder.DropTable(
                name: "Sugerencia");

            migrationBuilder.DropTable(
                name: "Restaurante");
        }
    }
}

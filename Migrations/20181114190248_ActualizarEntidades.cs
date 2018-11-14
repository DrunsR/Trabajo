using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabajo.Migrations
{
    public partial class ActualizarEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroMenus");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Restaurante",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RUC",
                table: "Restaurante",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Platillo",
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
                    table.PrimaryKey("PK_Platillo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platillo_Restaurante_regId",
                        column: x => x.regId,
                        principalTable: "Restaurante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Platillo_regId",
                table: "Platillo",
                column: "regId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Platillo");

            migrationBuilder.AlterColumn<int>(
                name: "telefono",
                table: "Restaurante",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RUC",
                table: "Restaurante",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.CreateTable(
                name: "RegistroMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Imagen = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Precio = table.Column<int>(nullable: false),
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
                name: "IX_RegistroMenus_regId",
                table: "RegistroMenus",
                column: "regId");
        }
    }
}

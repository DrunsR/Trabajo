using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabajo.Migrations
{
    public partial class perfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sugerencia_Restaurante_RestId",
                table: "Sugerencia");

            migrationBuilder.DropColumn(
                name: "RegistroRestId",
                table: "Sugerencia");

            migrationBuilder.AlterColumn<int>(
                name: "RestId",
                table: "Sugerencia",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sugerencia_Restaurante_RestId",
                table: "Sugerencia",
                column: "RestId",
                principalTable: "Restaurante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sugerencia_Restaurante_RestId",
                table: "Sugerencia");

            migrationBuilder.AlterColumn<int>(
                name: "RestId",
                table: "Sugerencia",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RegistroRestId",
                table: "Sugerencia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Sugerencia_Restaurante_RestId",
                table: "Sugerencia",
                column: "RestId",
                principalTable: "Restaurante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

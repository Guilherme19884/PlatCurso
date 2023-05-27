using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlataformaDeCurso.Migrations
{
    public partial class AlteracaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "cursos");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "cursos",
                newName: "nomeCurso");

            migrationBuilder.AddColumn<float>(
                name: "duracao",
                table: "cursos",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duracao",
                table: "cursos");

            migrationBuilder.RenameColumn(
                name: "nomeCurso",
                table: "cursos",
                newName: "nome");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "cursos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}

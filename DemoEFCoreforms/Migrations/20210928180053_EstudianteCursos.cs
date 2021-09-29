using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCoreforms.Migrations
{
    public partial class EstudianteCursos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApeMaterno",
                table: "Estudiantes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApePaterno",
                table: "Estudiantes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetalleId",
                table: "Estudiantes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteDetalles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteCursos",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteCursos", x => new { x.CursoId, x.EstudianteId });
                    table.ForeignKey(
                        name: "FK_EstudianteCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudianteCursos_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_DetalleId",
                table: "Estudiantes",
                column: "DetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteCursos_EstudianteId",
                table: "EstudianteCursos",
                column: "EstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_EstudianteDetalles_DetalleId",
                table: "Estudiantes",
                column: "DetalleId",
                principalTable: "EstudianteDetalles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_EstudianteDetalles_DetalleId",
                table: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "EstudianteCursos");

            migrationBuilder.DropTable(
                name: "EstudianteDetalles");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_DetalleId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "ApeMaterno",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "ApePaterno",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "DetalleId",
                table: "Estudiantes");
        }
    }
}

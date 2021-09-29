using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCoreforms.Migrations
{
    public partial class IsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActivie",
                table: "EstudianteCursos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActivie",
                table: "EstudianteCursos");
        }
    }
}

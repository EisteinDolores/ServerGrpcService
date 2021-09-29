using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCoreforms.Migrations
{
    public partial class EstudianteRegistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "ApeMaterno", "ApePaterno", "DetalleId", "FechaNacimiento", "Nombres" },
                values: new object[] { 1, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eistein Dolores" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "ApeMaterno", "ApePaterno", "DetalleId", "FechaNacimiento", "Nombres" },
                values: new object[] { 2, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jenny Cuya" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

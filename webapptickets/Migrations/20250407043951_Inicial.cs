using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPITickets.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ro_identificador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ro_decripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ro_fecha_adicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ro_adicionado_por = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ro_fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ro_modificado_por = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ro_identificador);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    us_identificador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    us_nombre_completo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    us_correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    us_clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    us_ro_identificador = table.Column<int>(type: "int", nullable: false),
                    us_estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    us_fecha_adicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    us_adicionado_por = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    us_fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    us_modificado_por = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.us_identificador);
                });

            migrationBuilder.CreateTable(
                name: "Tiquetes",
                columns: table => new
                {
                    ti_identificador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ti_asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_us_id_asigna = table.Column<int>(type: "int", nullable: false),
                    ti_urgencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_importancia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_solucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_fecha_adicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ti_adicionado_por = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ti_fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ti_modificado_por = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rolesro_identificador = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiquetes", x => x.ti_identificador);
                    table.ForeignKey(
                        name: "FK_Tiquetes_Roles_Rolesro_identificador",
                        column: x => x.Rolesro_identificador,
                        principalTable: "Roles",
                        principalColumn: "ro_identificador");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tiquetes_Rolesro_identificador",
                table: "Tiquetes",
                column: "Rolesro_identificador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiquetes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}

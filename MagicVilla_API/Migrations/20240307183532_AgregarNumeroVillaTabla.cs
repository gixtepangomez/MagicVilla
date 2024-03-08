using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNumeroVillaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MetrosCuadrados",
                table: "Villas",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateTable(
                name: "NumeroVillas",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    DetalleEspecial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumeroVillas", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_NumeroVillas_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2024, 3, 7, 12, 35, 32, 302, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 3, 7, 12, 35, 32, 302, DateTimeKind.Local).AddTicks(4851), 50 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2024, 3, 7, 12, 35, 32, 302, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 3, 7, 12, 35, 32, 302, DateTimeKind.Local).AddTicks(4867), 50 });

            migrationBuilder.CreateIndex(
                name: "IX_NumeroVillas_VillaId",
                table: "NumeroVillas",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumeroVillas");

            migrationBuilder.AlterColumn<double>(
                name: "MetrosCuadrados",
                table: "Villas",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2309), 50.0 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2326), 50.0 });
        }
    }
}

﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2309), "", 50.0, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa....", new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 1, 9, 15, 2, 18, 798, DateTimeKind.Local).AddTicks(2326), "", 50.0, "Premium Vista a la Piscina", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

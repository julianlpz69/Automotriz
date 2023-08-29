using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_ordenServicio_IdOrdenServicioFK",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_IdOrdenServicioFK",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "IdOrdenServicioFK",
                table: "vehiculo");

            migrationBuilder.AddColumn<int>(
                name: "IdFactura",
                table: "ordenServicio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrdenServicio = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroFactura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaFactura = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ordenServicio_IdFactura",
                table: "ordenServicio",
                column: "IdFactura",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ordenServicio_IdVehiculoFK",
                table: "ordenServicio",
                column: "IdVehiculoFK");

            migrationBuilder.AddForeignKey(
                name: "FK_ordenServicio_factura_IdFactura",
                table: "ordenServicio",
                column: "IdFactura",
                principalTable: "factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ordenServicio_vehiculo_IdVehiculoFK",
                table: "ordenServicio",
                column: "IdVehiculoFK",
                principalTable: "vehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ordenServicio_factura_IdFactura",
                table: "ordenServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_ordenServicio_vehiculo_IdVehiculoFK",
                table: "ordenServicio");

            migrationBuilder.DropTable(
                name: "factura");

            migrationBuilder.DropIndex(
                name: "IX_ordenServicio_IdFactura",
                table: "ordenServicio");

            migrationBuilder.DropIndex(
                name: "IX_ordenServicio_IdVehiculoFK",
                table: "ordenServicio");

            migrationBuilder.DropColumn(
                name: "IdFactura",
                table: "ordenServicio");

            migrationBuilder.AddColumn<int>(
                name: "IdOrdenServicioFK",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_IdOrdenServicioFK",
                table: "vehiculo",
                column: "IdOrdenServicioFK",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_ordenServicio_IdOrdenServicioFK",
                table: "vehiculo",
                column: "IdOrdenServicioFK",
                principalTable: "ordenServicio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

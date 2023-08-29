using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargoEmpleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescripcionCargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargoEmpleado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EstadoCliente = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidosPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CedulaPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DireccionPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistroPersona = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "experto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EspecialidadExperto = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidosPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CedulaPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DireccionPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistroPersona = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "repuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoRepuesto = table.Column<int>(type: "int", nullable: false),
                    ValorRepuesto = table.Column<double>(type: "double", nullable: false),
                    StockRepuesto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repuesto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescripcinVehiculo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadPuestosVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoVehiculo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ordenServicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroOrdenServicio = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaOrdenServicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdClienteFK = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoCliente = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdVehiculoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordenServicio_cliente_IdClienteFK",
                        column: x => x.IdClienteFK,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EspacialidadEmpleado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCargoEmpleadoFK = table.Column<int>(type: "int", nullable: false),
                    IdOrdenServicioFK = table.Column<int>(type: "int", nullable: false),
                    NombrePersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidosPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CedulaPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DireccionPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistroPersona = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empleado_cargoEmpleado_IdCargoEmpleadoFK",
                        column: x => x.IdCargoEmpleadoFK,
                        principalTable: "cargoEmpleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_ordenServicio_IdOrdenServicioFK",
                        column: x => x.IdOrdenServicioFK,
                        principalTable: "ordenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "expertoDiagnostico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaDiagnosticoExperto = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdExpertoFK = table.Column<int>(type: "int", nullable: false),
                    IdOrdenServicioFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expertoDiagnostico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_expertoDiagnostico_experto_IdExpertoFK",
                        column: x => x.IdExpertoFK,
                        principalTable: "experto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_expertoDiagnostico_ordenServicio_IdOrdenServicioFK",
                        column: x => x.IdOrdenServicioFK,
                        principalTable: "ordenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlacaVehiculo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MarcaVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KilometrajeVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModeloVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaIngresoVehiculo = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaSalidaVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObservacionesVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoVehiculoFK = table.Column<int>(type: "int", nullable: false),
                    IdClienteFK = table.Column<int>(type: "int", nullable: false),
                    IdOrdenServicioFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehiculo_cliente_IdClienteFK",
                        column: x => x.IdClienteFK,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculo_ordenServicio_IdOrdenServicioFK",
                        column: x => x.IdOrdenServicioFK,
                        principalTable: "ordenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculo_tipoVehiculo_IdTipoVehiculoFK",
                        column: x => x.IdTipoVehiculoFK,
                        principalTable: "tipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ordenAprovacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroOrdenAprovacion = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaOrdenAprovacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdEmpleadoFK = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true),
                    IdOrdenServicioFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenAprovacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordenAprovacion_empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ordenAprovacion_ordenServicio_IdOrdenServicioFK",
                        column: x => x.IdOrdenServicioFK,
                        principalTable: "ordenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "repuestoOrden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CantidadRepuesto = table.Column<int>(type: "int", nullable: false),
                    EstadoRepuesto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRespuestoFK = table.Column<int>(type: "int", nullable: false),
                    IdOrdenAprovacionFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repuestoOrden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_repuestoOrden_ordenAprovacion_IdOrdenAprovacionFK",
                        column: x => x.IdOrdenAprovacionFK,
                        principalTable: "ordenAprovacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_repuestoOrden_repuesto_IdRespuestoFK",
                        column: x => x.IdRespuestoFK,
                        principalTable: "repuesto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdCargoEmpleadoFK",
                table: "empleado",
                column: "IdCargoEmpleadoFK");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdOrdenServicioFK",
                table: "empleado",
                column: "IdOrdenServicioFK");

            migrationBuilder.CreateIndex(
                name: "IX_expertoDiagnostico_IdExpertoFK",
                table: "expertoDiagnostico",
                column: "IdExpertoFK");

            migrationBuilder.CreateIndex(
                name: "IX_expertoDiagnostico_IdOrdenServicioFK",
                table: "expertoDiagnostico",
                column: "IdOrdenServicioFK");

            migrationBuilder.CreateIndex(
                name: "IX_ordenAprovacion_EmpleadoId",
                table: "ordenAprovacion",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ordenAprovacion_IdOrdenServicioFK",
                table: "ordenAprovacion",
                column: "IdOrdenServicioFK");

            migrationBuilder.CreateIndex(
                name: "IX_ordenServicio_IdClienteFK",
                table: "ordenServicio",
                column: "IdClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_repuestoOrden_IdOrdenAprovacionFK",
                table: "repuestoOrden",
                column: "IdOrdenAprovacionFK");

            migrationBuilder.CreateIndex(
                name: "IX_repuestoOrden_IdRespuestoFK",
                table: "repuestoOrden",
                column: "IdRespuestoFK");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_IdClienteFK",
                table: "vehiculo",
                column: "IdClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_IdOrdenServicioFK",
                table: "vehiculo",
                column: "IdOrdenServicioFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_IdTipoVehiculoFK",
                table: "vehiculo",
                column: "IdTipoVehiculoFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "expertoDiagnostico");

            migrationBuilder.DropTable(
                name: "repuestoOrden");

            migrationBuilder.DropTable(
                name: "vehiculo");

            migrationBuilder.DropTable(
                name: "experto");

            migrationBuilder.DropTable(
                name: "ordenAprovacion");

            migrationBuilder.DropTable(
                name: "repuesto");

            migrationBuilder.DropTable(
                name: "tipoVehiculo");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "cargoEmpleado");

            migrationBuilder.DropTable(
                name: "ordenServicio");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}

﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AutomotrizBDContext))]
    partial class AutomotrizBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.CargoEmpleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionCargo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("cargoEmpleado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApellidosPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("CedulaPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("DireccionPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EmailPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoCliente")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("FechaRegistroPersona")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NombrePersona")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonoPersona")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApellidosPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("CedulaPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("DireccionPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EmailPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EspacialidadEmpleado")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("FechaRegistroPersona")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCargoEmpleadoFK")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenServicioFK")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonoPersona")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCargoEmpleadoFK");

                    b.HasIndex("IdOrdenServicioFK");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Experto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApellidosPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("CedulaPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("DireccionPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EmailPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EspecialidadExperto")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("FechaRegistroPersona")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NombrePersona")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonoPersona")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("experto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ExpertoDiagnostico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("FechaDiagnosticoExperto")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdExpertoFK")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenServicioFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdExpertoFK");

                    b.HasIndex("IdOrdenServicioFK");

                    b.ToTable("expertoDiagnostico", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IdOrdenServicio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NumeroFactura")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("factura", (string)null);
                });

            modelBuilder.Entity("Core.Entities.OrdenAprovacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaOrdenAprovacion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmpleadoFK")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenServicioFK")
                        .HasColumnType("int");

                    b.Property<string>("NumeroOrdenAprovacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("IdOrdenServicioFK");

                    b.ToTable("ordenAprovacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.OrdenServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiagnosticoCliente")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaOrdenServicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdClienteFK")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdVehiculoFK")
                        .HasColumnType("int");

                    b.Property<string>("NumeroOrdenServicio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFK");

                    b.HasIndex("IdFactura")
                        .IsUnique();

                    b.HasIndex("IdVehiculoFK");

                    b.ToTable("ordenServicio", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Repuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodigoRepuesto")
                        .HasColumnType("int");

                    b.Property<int>("StockRepuesto")
                        .HasColumnType("int");

                    b.Property<double>("ValorRepuesto")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("repuesto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.RepuestoOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadRepuesto")
                        .HasColumnType("int");

                    b.Property<string>("EstadoRepuesto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdOrdenAprovacionFK")
                        .HasColumnType("int");

                    b.Property<int>("IdRespuestoFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdOrdenAprovacionFK");

                    b.HasIndex("IdRespuestoFK");

                    b.ToTable("repuestoOrden", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadPuestosVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("DescripcinVehiculo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipoVehiculo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorVehiculo")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoVehiculo")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaIngresoVehiculo")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FechaSalidaVehiculo")
                        .HasColumnType("longtext");

                    b.Property<int>("IdClienteFK")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoVehiculoFK")
                        .HasColumnType("int");

                    b.Property<string>("KilometrajeVehiculo")
                        .HasColumnType("longtext");

                    b.Property<string>("MarcaVehiculo")
                        .HasColumnType("longtext");

                    b.Property<string>("ModeloVehiculo")
                        .HasColumnType("longtext");

                    b.Property<string>("ObservacionesVehiculo")
                        .HasColumnType("longtext");

                    b.Property<string>("PlacaVehiculo")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFK");

                    b.HasIndex("IdTipoVehiculoFK");

                    b.ToTable("vehiculo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Empleado", b =>
                {
                    b.HasOne("Core.Entities.CargoEmpleado", "CargoEmpleado")
                        .WithMany("Empleados")
                        .HasForeignKey("IdCargoEmpleadoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.OrdenServicio", "OrdenServicio")
                        .WithMany("Empleados")
                        .HasForeignKey("IdOrdenServicioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoEmpleado");

                    b.Navigation("OrdenServicio");
                });

            modelBuilder.Entity("Core.Entities.ExpertoDiagnostico", b =>
                {
                    b.HasOne("Core.Entities.Experto", "Experto")
                        .WithMany("ExpertoDiagnosticos")
                        .HasForeignKey("IdExpertoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.OrdenServicio", "OrdenServicio")
                        .WithMany("ExpertosDiagnosticos")
                        .HasForeignKey("IdOrdenServicioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experto");

                    b.Navigation("OrdenServicio");
                });

            modelBuilder.Entity("Core.Entities.OrdenAprovacion", b =>
                {
                    b.HasOne("Core.Entities.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("Core.Entities.OrdenServicio", "OrdenServicio")
                        .WithMany("OrdenesAprovacion")
                        .HasForeignKey("IdOrdenServicioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("OrdenServicio");
                });

            modelBuilder.Entity("Core.Entities.OrdenServicio", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Cliente")
                        .WithMany("OrdenesServicios")
                        .HasForeignKey("IdClienteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Factura", "Factura")
                        .WithOne("OrdenServicio")
                        .HasForeignKey("Core.Entities.OrdenServicio", "IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Vehiculo", "Vehiculo")
                        .WithMany("OrdenesServicio")
                        .HasForeignKey("IdVehiculoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Factura");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Core.Entities.RepuestoOrden", b =>
                {
                    b.HasOne("Core.Entities.OrdenAprovacion", "OrdenAprovacion")
                        .WithMany("RepuestoOrdenes")
                        .HasForeignKey("IdOrdenAprovacionFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Repuesto", "Repuesto")
                        .WithMany("RepuestoOrdenes")
                        .HasForeignKey("IdRespuestoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdenAprovacion");

                    b.Navigation("Repuesto");
                });

            modelBuilder.Entity("Core.Entities.Vehiculo", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Cliente")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdClienteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoVehiculo", "TipoVehiculo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdTipoVehiculoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoVehiculo");
                });

            modelBuilder.Entity("Core.Entities.CargoEmpleado", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Navigation("OrdenesServicios");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Core.Entities.Experto", b =>
                {
                    b.Navigation("ExpertoDiagnosticos");
                });

            modelBuilder.Entity("Core.Entities.Factura", b =>
                {
                    b.Navigation("OrdenServicio");
                });

            modelBuilder.Entity("Core.Entities.OrdenAprovacion", b =>
                {
                    b.Navigation("RepuestoOrdenes");
                });

            modelBuilder.Entity("Core.Entities.OrdenServicio", b =>
                {
                    b.Navigation("Empleados");

                    b.Navigation("ExpertosDiagnosticos");

                    b.Navigation("OrdenesAprovacion");
                });

            modelBuilder.Entity("Core.Entities.Repuesto", b =>
                {
                    b.Navigation("RepuestoOrdenes");
                });

            modelBuilder.Entity("Core.Entities.TipoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Core.Entities.Vehiculo", b =>
                {
                    b.Navigation("OrdenesServicio");
                });
#pragma warning restore 612, 618
        }
    }
}

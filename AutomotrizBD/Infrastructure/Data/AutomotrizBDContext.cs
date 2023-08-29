using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data;

public class AutomotrizBDContext : DbContext
{
    public AutomotrizBDContext(DbContextOptions<AutomotrizBDContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes{ get; set; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Experto> Expertos { get; set; }
    public DbSet<CargoEmpleado> CargosEmpleados { get; set; }
    public DbSet<ExpertoDiagnostico> ExpertosDiagnosticos { get; set;}
    public DbSet<OrdenAprovacion> OrdenesAprovacion { get; set;}
    public DbSet<OrdenServicio> OrdenesServicio { get; set;}
    public DbSet<Repuesto> Repuestos { get; set;}
    public DbSet<RepuestoOrden> RepuestosOrdenes { get; set;}
    public DbSet<TipoVehiculo> TiposVehiculos { get; set;}
    public DbSet<Vehiculo> Vehiculos { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        modelBuilder.Entity<CargoEmpleado>() 
            .HasMany<Empleado>(g => g.Empleados) 
            .WithOne(s => s.CargoEmpleado) 
            .HasForeignKey(s => s.IdCargoEmpleadoFK);


        modelBuilder.Entity<Cliente>() 
            .HasMany<Vehiculo>(g => g.Vehiculos) 
            .WithOne(s => s.Cliente) 
            .HasForeignKey(s => s.IdClienteFK);   


        modelBuilder.Entity<Cliente>() 
            .HasMany<OrdenServicio>(g => g.OrdenesServicios) 
            .WithOne(s => s.Cliente) 
            .HasForeignKey(s => s.IdClienteFK);    


        modelBuilder.Entity<Experto>() 
            .HasMany<ExpertoDiagnostico>(g => g.ExpertoDiagnosticos) 
            .WithOne(s => s.Experto) 
            .HasForeignKey(s => s.IdExpertoFK);


        modelBuilder.Entity<OrdenAprovacion>() 
            .HasMany<RepuestoOrden>(g => g.RepuestoOrdenes) 
            .WithOne(s => s.OrdenAprovacion) 
            .HasForeignKey(s => s.IdOrdenAprovacionFK);    


        modelBuilder.Entity<OrdenServicio>() 
            .HasMany<Empleado>(g => g.Empleados) 
            .WithOne(s => s.OrdenServicio) 
            .HasForeignKey(s => s.IdOrdenServicioFK);    


        modelBuilder.Entity<OrdenServicio>() 
            .HasMany<OrdenAprovacion>(g => g.OrdenesAprovacion) 
            .WithOne(s => s.OrdenServicio) 
            .HasForeignKey(s => s.IdOrdenServicioFK);        


        modelBuilder.Entity<OrdenServicio>() 
            .HasMany<ExpertoDiagnostico>(g => g.ExpertosDiagnosticos) 
            .WithOne(s => s.OrdenServicio) 
            .HasForeignKey(s => s.IdOrdenServicioFK);


        modelBuilder.Entity<Repuesto>() 
            .HasMany<RepuestoOrden>(g => g.RepuestoOrdenes) 
            .WithOne(s => s.Repuesto) 
            .HasForeignKey(s => s.IdRespuestoFK); 


        modelBuilder.Entity<TipoVehiculo>() 
            .HasMany<Vehiculo>(g => g.Vehiculos) 
            .WithOne(s => s.TipoVehiculo) 
            .HasForeignKey(s => s.IdTipoVehiculoFK); 


        modelBuilder.Entity<Vehiculo>() 
            .HasMany<OrdenServicio>(g => g.OrdenesServicio) 
            .WithOne(s => s.Vehiculo) 
            .HasForeignKey(s => s.IdVehiculoFK); 

    

        modelBuilder.Entity<Factura>()
            .HasOne(o => o.OrdenServicio)
            .WithOne(v => v.Factura)
            .HasForeignKey<OrdenServicio>(v => v.IdFactura);

    }

}
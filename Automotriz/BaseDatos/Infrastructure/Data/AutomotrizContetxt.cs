using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Core.Entities;

public class AutomotrizContext : DbContext
{
    public AutomotrizContext(DbContextOptions<AutomotrizContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // modelBuilder.Entity<Pais>() 
        //     .HasMany<Estado>(g => g.Estados) 
        //     .WithOne(s => s.Pais) 
        //     .HasForeignKey(s => s.IdPaisFk);

        // modelBuilder.Entity<Estado>() 
        //     .HasMany<Region>(g => g.Regiones) 
        //     .WithOne(s => s.Estado) 
        //     .HasForeignKey(s => s.IdEstadoFk);    


        // modelBuilder.Entity<TipoPersona>() 
        //     .HasMany<Persona>(g => g.Personas) 
        //     .WithOne(s => s.TipoPersona) 
        //     .HasForeignKey(s => s.IdTipoPerFk);    


  
        // modelBuilder.Entity<ProductoPersona> ( ).HasKey(sc => new { sc.IdProducto, sc.IdPersona });

        // modelBuilder.Entity<ProductoPersona> ( )
        //     .HasOne< Producto >(sc => sc.Producto)
        //     .WithMany(s => s.ProductosPersonas)
        //     .HasForeignKey(sc => sc.IdProducto);


        // modelBuilder.Entity<ProductoPersona> ( )
        //     .HasOne<Persona>(sc => sc.Persona)
        //     .WithMany(s => s.ProductosPersonas)
        //     .HasForeignKey(sc => sc.IdPersona);


    }

}

public class Cliente
{
}
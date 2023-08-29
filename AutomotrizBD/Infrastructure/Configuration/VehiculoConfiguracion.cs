using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class VehiculoConfiguracion: IEntityTypeConfiguration<Vehiculo> 
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("vehiculo");

            builder.Property(p => p.PlacaVehiculo)
            .HasMaxLength(10);
            
        }
    }

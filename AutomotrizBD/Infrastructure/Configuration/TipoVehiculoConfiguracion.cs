using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class TipoVehiculoConfiguracion: IEntityTypeConfiguration<TipoVehiculo> 
    {
        public void Configure(EntityTypeBuilder<TipoVehiculo> builder)
        {
            builder.ToTable("tipoVehiculo");

            builder.Property(p => p.DescripcinVehiculo)
            .HasMaxLength(50);
            
        }
    }

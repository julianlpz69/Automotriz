using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class CargoEmpleadoConfiguracion: IEntityTypeConfiguration<CargoEmpleado>
    {
        public void Configure(EntityTypeBuilder<CargoEmpleado> builder)
        {
            builder.ToTable("cargoEmpleado");

            builder.Property(p => p.DescripcionCargo)
            .HasMaxLength(50)
            .IsRequired();

        }
    }

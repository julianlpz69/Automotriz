using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class RepuestoOrdenConfiguracion: IEntityTypeConfiguration<RepuestoOrden> 
    {
        public void Configure(EntityTypeBuilder<RepuestoOrden> builder)
        {
            builder.ToTable("repuestoOrden");

            builder.Property(p => p.EstadoRepuesto)
            .IsRequired();
        
        }
    }

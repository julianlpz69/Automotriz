using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class OrdenServicioConfiguracion: IEntityTypeConfiguration<OrdenServicio> 
    {
        public void Configure(EntityTypeBuilder<OrdenServicio> builder)
        {
            builder.ToTable("ordenServicio");

            builder.Property(p => p.NumeroOrdenServicio)
            .HasMaxLength(20)
            .IsRequired();
        
        }
    }

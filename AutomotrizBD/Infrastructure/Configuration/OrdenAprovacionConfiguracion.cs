using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class OrdenAprovacionConfiguracion: IEntityTypeConfiguration<OrdenAprovacion> 
    {
        public void Configure(EntityTypeBuilder<OrdenAprovacion> builder)
        {
            builder.ToTable("ordenAprovacion");

            builder.Property(p => p.NumeroOrdenAprovacion)
            .HasMaxLength(20)
            .IsRequired();
        
        }
    }

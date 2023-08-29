using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class FacturaConfiguration: IEntityTypeConfiguration<Factura> 
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("factura");

            builder.Property(p => p.NumeroFactura)
            .IsRequired()
            .HasMaxLength(50);
        
        }
    }

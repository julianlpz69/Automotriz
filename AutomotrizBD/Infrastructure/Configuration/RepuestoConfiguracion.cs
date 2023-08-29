using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class RepuestoConfiguracion: IEntityTypeConfiguration<Repuesto> 
    {
        public void Configure(EntityTypeBuilder<Repuesto> builder)
        {
            builder.ToTable("repuesto");

            builder.Property(p => p.CodigoRepuesto)
            .IsRequired();
        
        }
    }

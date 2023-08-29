using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class ExpertoDiagnosticoConfiguracion: IEntityTypeConfiguration<ExpertoDiagnostico> 
    {
        public void Configure(EntityTypeBuilder<ExpertoDiagnostico> builder)
        {
            builder.ToTable("expertoDiagnostico");

            builder.Property(p => p.Descripcion)
            .HasMaxLength(50);
        
        }
    }

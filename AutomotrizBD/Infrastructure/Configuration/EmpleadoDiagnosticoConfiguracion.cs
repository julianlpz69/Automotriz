using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class EmpleadoDiagnosticoConfiguracion: IEntityTypeConfiguration<EmpleadoDiagnostico> 
    {
        public void Configure(EntityTypeBuilder<EmpleadoDiagnostico> builder)
        {
            builder.ToTable("empleadoDiagnostico");

            builder.Property(p => p.Descripcion)
            .HasMaxLength(50);
        
        }
    }

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class EmpleadoConfiguracion : IEntityTypeConfiguration<Empleado> 
    {
         public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleado");

            builder.Property(p => p.EspacialidadEmpleado)
            .HasMaxLength(30);
        
        }
    }
}
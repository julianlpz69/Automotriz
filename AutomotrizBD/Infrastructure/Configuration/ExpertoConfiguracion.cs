using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class ExpertoConfiguracion: IEntityTypeConfiguration<Experto> 
    {
        public void Configure(EntityTypeBuilder<Experto> builder)
        {
            builder.ToTable("experto");

            builder.Property(p => p.EspecialidadExperto)
            .HasMaxLength(20);
        
        }
    }

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration;

    public class ClienteConfiguracion: IEntityTypeConfiguration<Cliente> 
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.Property(p => p.EstadoCliente)
            .HasMaxLength(20);
        
        }
    }

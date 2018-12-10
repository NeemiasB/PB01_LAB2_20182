using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGE.ApplicationCore.Entity;


namespace SGE.Infrastructure.EntityConfig
{
    public class EventoConfig : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            // Configurando a entidade Evento com Fluent API
            builder.Property(x => x.Descricao)
           .HasColumnType("varchar(100)");


        }
    }
}
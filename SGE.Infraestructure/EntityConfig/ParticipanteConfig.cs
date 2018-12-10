using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGE.ApplicationCore.Entity;


namespace SGE.Infrastructure.EntityConfig
{
    public class MarcaConfig : IEntityTypeConfiguration<Participante>
    {
        public void Configure(EntityTypeBuilder<Participante> builder)
        {
           // Configurando a entidade Marca com Fluent API
            builder.Property(x => x.Nome)
           .HasColumnType("varchar(30)");

            builder.Property(x => x.Email)
          .HasColumnType("varchar(30)");


        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGE.ApplicationCore.Entity;


namespace SGE.Infrastructure.EntityConfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // Configurando a entidade Endereco com Fluent API
            builder.Property(x => x.Logradouro)
           .HasColumnType("varchar(100)");

            builder.Property(x => x.Bairro)
          .HasColumnType("varchar(100)");

            builder.Property(x => x.CEP)
          .HasColumnType("varchar(9)");

            builder.Property(x => x.Numero)
          .HasColumnType("varchar(4)");


        }
    }
}
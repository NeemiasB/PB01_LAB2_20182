using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGE.ApplicationCore.Entity;


namespace SGE.Infrastructure.EntityConfig
{
    public class GrupoTematicoConfig : IEntityTypeConfiguration<GrupoTematico>
    {
        public void Configure(EntityTypeBuilder<GrupoTematico> builder)
        {
            // Configurando a entidade GrupoTematico com Fluent API
            builder.Property(x => x.Descricao)
           .HasColumnType("varchar(100)");


        }
    }
}
using Microsoft.EntityFrameworkCore;
using SGE.ApplicationCore;
using SGE.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Infraestructure.Data
{
    public class SGEContext : DbContext
    {

        public SGEContext()
        {


        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<GrupoTematico> GruposTematicos { get; set; }
        public DbSet<Inscricao> Inscricaos { get; set; }
        public DbSet<InscricaoGrupoTematico> InscricaoGrupoTematicos { get; set; }
        public DbSet<Participante> Participantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGE;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configurando a entidade Endereco com Fluent API
            modelBuilder.Entity<Endereco>()
               .Property(x => x.Logradouro)
               .HasColumnType("varchar(100)");

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Bairro)
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Endereco>()
                .Property(x => x.CEP)
                .HasColumnType("varchar(9)");

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Numero)
                .HasColumnType("varchar(4)");



            // Configurando a entidade Evento com Fluent API
            modelBuilder.Entity<Evento>()
               .Property(x => x.Descricao)
               .HasColumnType("varchar(100)");

           

            // Configurando a entidade GrupoTematico com Fluent API
            modelBuilder.Entity<GrupoTematico>()
               .Property(x => x.Descricao)
               .HasColumnType("varchar(100)");

            

         


        }


    }
}
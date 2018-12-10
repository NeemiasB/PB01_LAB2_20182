using Microsoft.EntityFrameworkCore;
using SGE.ApplicationCore;
using SGE.ApplicationCore.Entity;
using SGE.Infrastructure.EntityConfig;
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

            modelBuilder.ApplyConfiguration(new EnderecoConfig());

            modelBuilder.ApplyConfiguration(new EventoConfig());

            modelBuilder.ApplyConfiguration(new GrupoTematicoConfig());

            modelBuilder.ApplyConfiguration(new ParticipanteConfig());


          /*  //Propagação de dados de Endereco
            modelBuilder.Entity<Endereco>()
                .HasData(

                new Endereco { EnderecoId = 1, Logradouro= "Cuiaba", Bairro="Dr. Fabio", CEP="00000-000", Numero= "1000"}

                );

            //Propagação de dados de Evento
            modelBuilder.Entity<Evento>()
                .HasData(

                new Evento { EventoId = 1, Descricao="Cleyton Rasta, cabeça de gelo"  }

                );

            //Propagação de dados GrupoTematico
            modelBuilder.Entity<GrupoTematico>()
                .HasData(

                new GrupoTematico { GrupoTematicoId= 1, Descricao="Grupo Maluco" }

                );

            //Propagação de dados Inscricao
            modelBuilder.Entity<Inscricao>()
                .HasData(

                new Inscricao { InscricaoId=1, DataCadastro= System.DateTime.Today, Valor= 100 }

                );

            modelBuilder.Entity<InscricaoGrupoTematico>()
                .HasData(

                new InscricaoGrupoTematico { InscricaoGrupoTematicoId= 1, GrupoTematicoId= 1, InscricaoId= 1}

                );


    */



        }


    }
}
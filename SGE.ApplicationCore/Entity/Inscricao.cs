using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Inscricao
    {
        public int InscricaoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public double Valor { get; set; }

        public Participante Participante { get; set; }

        public List<Evento> Eventos { get; set; }

        public List<InscricaoGrupoTematico> InscricaoGrupoTematicos { get; set; }


    }
}
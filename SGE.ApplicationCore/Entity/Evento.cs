using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Evento
    {
        public int EventoId { get; set; }

        public string Descricao { get; set; }

        public Inscricao Inscricao { get; set; }

    }
}

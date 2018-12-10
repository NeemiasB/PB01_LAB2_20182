using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Participante
    {
        public int ParticipanteId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public List<Inscricao> Inscricao { get; set; }

      
        public Endereco Endereco { get; set; }
    }

}

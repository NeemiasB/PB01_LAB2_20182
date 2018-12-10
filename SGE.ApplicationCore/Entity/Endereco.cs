using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Endereco
    {
        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Numero { get; set; }


        public int ParticipanteId { get; set; }
        public Participante Participante { get; set; }
    }
}

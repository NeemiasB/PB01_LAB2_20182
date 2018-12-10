using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class GrupoTematico
    {
        public int GrupoTematicoId { get; set; }

        public string Descricao { get; set; }

        public List<InscricaoGrupoTematico> InscricaoGrupoTematicos { get; set; }
    }
}

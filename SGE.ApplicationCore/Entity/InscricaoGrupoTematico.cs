using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class InscricaoGrupoTematico
    {
        public int InscricaoGrupoTematicoId { get; set; }

        public int InscricaoId { get; set; }
        public Inscricao Inscricao { get; set; }

        public int GrupoTematicoId { get; set; }
        public GrupoTematico GrupoTematico { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Especialidades:Base
    {
        public string Nome { get; set; }
        public int ProcedimentoId { get; set; }
        public bool PgtoConvenio { get; set; }
        public bool PgtoParticular { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Medico_Especialidade : Base
    {
        public int MedicoId { get; set; }
        public int EspecialidadeId { get; set; }
    }
}

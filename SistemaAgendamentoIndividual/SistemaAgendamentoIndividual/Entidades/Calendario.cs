using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Calendario : Base
    {
        public int MedicoId { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Situacao { get; set; }
    }
}

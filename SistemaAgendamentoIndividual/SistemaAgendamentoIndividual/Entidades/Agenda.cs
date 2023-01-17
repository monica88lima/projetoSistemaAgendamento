using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Agenda:Base
    {
        public string Nome_Usuario { get; set; }
        public string Nome_Medico { get; set; }
        public string Nome_Especialidade { get; set; }
        public string Nome_Procedimento { get; set; }
        public string Nome_FormaPgto { get; set; }

        public DateTime Data_Marcada { get; set; }
        public DateTime Hora_Marcada { get; set; }

    }
}

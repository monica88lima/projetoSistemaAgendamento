using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Medicos:Base
    {
        public int Crm { get; set; }
        public string Nome { get; set; }

        public int Id_Especialidade { get; set; }
        public string Nome_Especialidade { get; set; }

        public int Id_Procedimento { get; set; }
        public string Nome_Procedimento{ get; set; }

        

    }
}

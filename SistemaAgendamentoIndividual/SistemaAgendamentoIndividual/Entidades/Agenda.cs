using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public  class Agenda:Base
    {
        public int Nome_Usuario { get; set; }
        public int Nome_Medico { get; set; }
        public int Nome_Especialidade { get; set; }
        public int Nome_Procedimento { get; set; }
        public int FormaPgto { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime Data_Marcada { get; set; }
        public DateTime Hora_Marcada { get; set; }

        public Agenda(int frmPgto, int escolhaProced, int espec, int dr, Calendario dataEhora)
        {
            this.FormaPgto = frmPgto;
            

        }
    }
}

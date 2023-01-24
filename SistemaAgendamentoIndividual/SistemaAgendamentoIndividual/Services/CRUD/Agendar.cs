using SistemaAgendamentoIndividual.Entidades;
using SistemaAgendamentoIndividual.Interfaces;
using SistemaAgendamentoIndividual.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Services.CRUD
{
    public class Agendar
    {
        private readonly IAgenda? _agendamento;

        public Agendar()
        {
            _agendamento = new Agenda_Metodo();
        }

        public void FazerAgendamento()
        {
            _agendamento.CriarAgendamento();

        }
    }
}

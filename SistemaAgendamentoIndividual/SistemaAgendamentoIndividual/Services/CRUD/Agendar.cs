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
        public void CriarAgendamento()
        {
            var usuario_pgto = new Metodos.FormaPgto_Metodo();
            int frmPgto = usuario_pgto.ExibirFormaPgto();

            var usuario_procedimento = new Metodos.Procedimentos_Metodo();
            int escolhaProced = usuario_procedimento.ExibirProcedimento();


            var usuario_especialidade = new Especialidade_Metodo();
            usuario_especialidade.Filtro(escolhaProced, frmPgto == 1, frmPgto == 2);
            int espec = usuario_especialidade.ColetarEspecialidade();

            var medico = new Medicos_Metodo();
            medico.Filtro(espec);
            int dr = medico.ColetarNomeMedico();

        }
        
    }
}

using SistemaAgendamentoIndividual.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Interfaces
{
    public interface IUsuario
    {
        Usuario Cadastrar();
        void ExibirMensagemBoasVindas(string Nome);
        Usuario LogarUsuario();
    }
}

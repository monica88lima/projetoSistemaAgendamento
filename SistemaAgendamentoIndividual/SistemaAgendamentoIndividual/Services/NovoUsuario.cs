using SistemaAgendamentoIndividual.Entidades;
using SistemaAgendamentoIndividual.Interfaces;
using SistemaAgendamentoIndividual.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Services
{
    public class NovoUsuario 
    {
        private readonly IUsuario? _iusuario;

        public NovoUsuario(IUsuario? iusuario)
        {
            _iusuario = iusuario;
        }
        public void IniciarNovoPerfil()
        {
            _iusuario.Cadastrar();
            _iusuario.ExibirMensagemBoasVindas();
        }
      
    }
}

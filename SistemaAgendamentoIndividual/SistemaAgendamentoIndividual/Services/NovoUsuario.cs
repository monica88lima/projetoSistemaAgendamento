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

        public NovoUsuario()
        {
            _iusuario = new Usuario_Metodo();
        }
        public Usuario IniciarNovoPerfil()
        {
            var usr = _iusuario.Cadastrar();
            _iusuario.ExibirMensagemBoasVindas(usr.Nome);
            return usr;
        }

    }
}

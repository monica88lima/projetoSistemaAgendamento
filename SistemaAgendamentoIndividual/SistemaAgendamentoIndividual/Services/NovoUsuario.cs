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

        public NovoUsuario(Usuario_Metodo usuario_Metodo)
        {
            _iusuario = usuario_Metodo;
        }
        public Usuario IniciarNovoPerfil()
        {
            var usuarioCriado= _iusuario.Cadastrar();
            _iusuario.ExibirMensagemBoasVindas(usuarioCriado.Nome);
            return usuarioCriado;
        }

    }
}

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
    public class LoginUsuario
    {
        private readonly IUsuario? _iusuario;
        public LoginUsuario()
        {
            _iusuario = new Usuario_Metodo();
        }
        public Usuario LogarUsuario()
        {
            var usuarioExistente = _iusuario.LogarUsuario();
            _iusuario.ExibirMensagemBoasVindas(usuarioExistente.Nome);
            return usuarioExistente;
;
        }
    }
}

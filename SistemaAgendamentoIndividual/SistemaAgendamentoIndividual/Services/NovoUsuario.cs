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
        public static void IniciarNovoPerfil()
        {
            IUsuario novoPerfil = new Usuario_Metodo();
            novoPerfil.Cadastrar();
            novoPerfil.ExibirMensagemBoasVindas();
        }
      
    }
}

using SistemaAgendamentoIndividual.Entidades;
using SistemaAgendamentoIndividual.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class Usuario_Metodo:Usuario, IUsuario
    {
        public void Cadastrar()
        {
            
            this.Nome = Services.ValidarEConverterEntradaDeUsuario.ColetarNomeCompleto();

            Console.WriteLine("Digite seu CPF:");
            this.CPF = Services.ValidarEConverterEntradaDeUsuario.ConverterParaLong();

            Console.WriteLine("Digite seu numero de Telefone Celular: ");
            this.Celular = Services.ValidarEConverterEntradaDeUsuario.ConverterParaLongCelular();

            Console.WriteLine("informe seu genero (1) Feminino (2) Masculino:");
            this.Sexo = Services.ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

            Console.WriteLine("Informe sua Data de Nascimento: (dia/mês/ano):");
            this.Data_Nascimento = Services.ValidarEConverterEntradaDeUsuario.ConverterParaDateTime();
        }

        public void ExibirMensagemBoasVindas()
        {
            string mensagem = $"Olá, {Nome.Split(" ")[0]}!!\nSeja Bem Vindo (a), vamos iniciar seu Agendamento?\n" +
                $"\n" +
                $"O que deseja fazer?\n" +
                $" ";
            Services.ConfiguraLayout.ClearLayout();
            Services.ConfiguraLayout.LayoutDoConsole();

            Console.WriteLine(mensagem);
        }

    }
}

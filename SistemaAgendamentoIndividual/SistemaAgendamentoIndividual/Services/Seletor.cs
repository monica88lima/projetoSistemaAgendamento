﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAgendamentoIndividual.Services.CRUD;

namespace SistemaAgendamentoIndividual.Services
{
    public class Seletor
    {

        public static List<string> Alternativas { get; set; } = new List<string>() { "Novo Agendamento", "Verificar Agendamentos Realizados", "Sair" };

        public static void MostrarAlternativas()
        {

            string descricaoMenu = "";


            for (int i = 1; i <= Alternativas.Count; i++)
            {
                descricaoMenu += $"({i}) {Alternativas[i - 1]} {Environment.NewLine}";
            }

            Console.WriteLine(descricaoMenu);
            IniciarSessaoPosEscolha(EscolherMenu());
            ConfiguraLayout.LayoutDoConsole();

        }

        //METODO QUE VERIFICA SE A OPÇÃO DIGITADA NO MENU EXISTE NAS ALTERNATIVAS LISTADAS
        private static string EscolherMenu()
        {
            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();
            bool itemExiste = retorno <= Alternativas.Count;

            if (itemExiste)
            {
                Console.WriteLine($"Você escolheu o item {retorno}");
                return Alternativas[retorno - 1];
            }
            else
            {
                Console.WriteLine("Menu não existe, por favor escolha um número válido.");
                return EscolherMenu();
            }
            //ConfiguraLayout.LayoutDoConsole();
        }
        private static void IniciarSessaoPosEscolha(string alternativaEscolhida)
        {
            switch (alternativaEscolhida)
            {
                case "Novo Agendamento":
                    new CRUD.Agendar().FazerAgendamento();
                    break;

                case "Verificar Agendamentos Realizados":
                    CRUD.Exibir.ExibirAgendamento();
                    break;

                case "Sair":
                    Environment.Exit(0);
                    break;
                    

                default:
                    break;
            }

        }

    }
}


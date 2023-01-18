﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Services
{
    public class ConfiguraLayout
    {
        public static void LayoutDoConsole()
        {
            Console.Title = "GRUPO 2";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------- 《 Agedamento de Consulta 》 ------");
            Console.WriteLine("-------------(☼ ☼ ☼)-------------");

        }

        //LIMPA O CONSOLE E CHAMA DE NOVO AS CONFIGURAÇÕES
        public static void ClearLayout()
        {
            Console.Clear();
            LayoutDoConsole();
            Console.WriteLine("\n");
        }
    }
}

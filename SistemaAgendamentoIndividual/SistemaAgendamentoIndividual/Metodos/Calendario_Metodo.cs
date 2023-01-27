using SistemaAgendamentoIndividual.Entidades;
using SistemaAgendamentoIndividual.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class Calendario_Metodo
    {
        public List<Entidades.Calendario> LstCalendarios { get; set; } = new();

        public Calendario_Metodo()
        {
            //leitura do arquivo
            string path = @"C:\Users\rishi\source\repos\projetoSistemaAgendamento\SistemaAgendamentoIndividual\SistemaAgendamentoIndividual\agenda.txt";
            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    LstCalendarios.Add(new Entidades.Calendario(sr.ReadLine()));
                }


            }
        }
        public void ExibirCalendario(int idMedicoEscolhido)
        {
            var cabecalho = "Verifique agenda disponivel e indique o dia e horaraio que deseja agendar sua consulta: ";
            var corpo = "";

            List<Entidades.Calendario> listaFiltrada = LstCalendarios.FindAll(x => x.MedicoId == idMedicoEscolhido);


            foreach (var item in listaFiltrada)
            {
                corpo += $"Código: {item.Id}---- Data:{item.Data} ---- Hora:{item.Hora} {Environment.NewLine}";
            }


            Console.WriteLine(cabecalho);
            Console.WriteLine(corpo);


        }

        public Calendario ColetarCalendario(int idMedico)
        {
            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();
            
            var resultado = LstCalendarios.Where(x => x.Id == retorno).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ExibirCalendario(idMedico);
            }

            return resultado;
            //esse retorno aqui tenho que mandar pra agenda metodo
        }
      


    }



}


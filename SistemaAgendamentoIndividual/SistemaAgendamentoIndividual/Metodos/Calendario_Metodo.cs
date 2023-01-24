using SistemaAgendamentoIndividual.Entidades;
using SistemaAgendamentoIndividual.Services;
using SistemaAgendamentoIndividual.Services.CRUD;
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

                //foreach (Entidades.Calendario item in LstCalendarios)
                //{
                //    Console.WriteLine($"Código: {item.Id}---- Data:{item.Data} ---- Hora:{item.Hora}");

                //}

                //var hora = 8;
                //var data = 1;
                //var random = new Random();
                //for (int i = 1; i <= 43; i++)
                //{
                //    if (hora > 16)
                //    {
                //        hora = 8;
                //        data++;
                //    }

                //    LstCalendarios.Add(
                //        new Entidades.Calendario()
                //        {
                //            Id = i,
                //            Data = DateTime.Now.AddDays(data).ToString("dd/MM/yyyy"),
                //            Hora = new DateTime(2023, 12, 1, hora, 0, 0).AddHours(i).ToString("HH:mm"),
                //            Situacao = "Livre",
                //            MedicoId = random.Next(1, 42)

                //        });
                //    File.AppendAllText(path, $"{Environment.NewLine}{i},{DateTime.Now.AddDays(data).ToString("dd/MM/yyyy")},{new DateTime(2023, 12, 1, hora, 0, 0).AddHours(i).ToString("HH:mm")},Livre, {random.Next(1, 42)}");

                //    hora++;


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

            ColetarCalendario(idMedicoEscolhido);


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


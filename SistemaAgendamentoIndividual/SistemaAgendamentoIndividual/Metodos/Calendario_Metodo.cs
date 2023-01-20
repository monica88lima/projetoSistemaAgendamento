using SistemaAgendamentoIndividual.Services;
using SistemaAgendamentoIndividual.Services.CRUD;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            var hora = 8;
            var data = 1;
            var random = new Random();
            for (int i = 1; i <= 42; i++)
            {                
                if (hora > 16)
                {
                    hora = 8;
                    data++;
                }

                LstCalendarios.Add(
                    new Entidades.Calendario()
                    {
                        Id = i,
                        Data = DateTime.Now.AddDays(data).ToString("dd/MM/YYYY"),
                        Hora = new DateTime(2023, 12, 1, hora, 0, 0).AddHours(i).ToString("HH:mm"),
                        Situacao = "L",
                        MedicoId = random.Next(1,42)
                    });

                hora++;
                
            }
        }

        public void ExibirCalendario()
        {
            var cabecalho = "Data                     Hora               Situação";
            var corpo = "";
            //foreach (var item in LstCalendarios)
            //{
            //    corpo += $"{item.Data}        {item.Hora}          {item.Situacao} {Environment.NewLine}";
            //}

            for (int i = 1; i <= LstCalendarios.Count; i++)
            {
                foreach (var item in LstCalendarios)
                {
                    corpo += $"{i} {item.Data}        {item.Hora}          {item.Situacao} {Environment.NewLine}";
                }
                
            }
            Console.WriteLine(cabecalho);
            Console.WriteLine(corpo);
            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();
            ColetarCalendario(retorno);
        }

        public int ColetarCalendario(int id)
        {
            int retorno = 0;
            var resultado = LstCalendarios.Where(x => x.Id == id).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ExibirCalendario();
            }
            else
            {
                retorno = id;
            }
            return retorno;
            //esse retorno aqui tenho que mandar pra agenda metodo
        }
    }
}

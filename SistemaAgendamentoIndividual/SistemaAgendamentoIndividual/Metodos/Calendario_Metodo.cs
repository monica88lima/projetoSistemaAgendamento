using System;
using System.Collections.Generic;
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
                        Situacao = "l",
                        MedicoId = i
                    });

                hora++;
                
            }
        }
    }
}

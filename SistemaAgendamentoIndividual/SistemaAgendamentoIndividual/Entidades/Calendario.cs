using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Calendario : Base
    {
        
        public int MedicoId { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
       
        public Calendario()
        {
            
        }
        public Calendario(string csvArquivo)
        {
            string[] vect = csvArquivo.Split(',');
            Id = int.Parse(vect[0]);
            MedicoId = int.Parse(vect[1]);
            Data = vect[2];
            Hora = vect[3];
            //Situacao = vect[4];
            
            

        }
    }
}

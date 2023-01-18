using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Usuario : Base
    {
        public string Nome { get; protected set; }
        public long CPF { get; protected set; }
        public DateTime Data_Nascimento { get; protected set; }
        public long Celular { get; protected set; }
        public int Sexo { get; protected set; }
       
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Entidades
{
    public class Usuario : Base
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public long Celular { get; set; }
        public char Sexo { get; set; }
    }
}

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
        public char Sexo { get; protected set; }
        public Usuario(string nome, long cpf, DateTime dataNascimento, char sexo, long contato )
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Data_Nascimento = dataNascimento;
            this.Sexo = sexo;
            this.Celular = contato;
            this.Id = 001;
        }
    }
}

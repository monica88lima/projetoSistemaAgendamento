using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class Procedimentos_Metodo
    {
        public List<Entidades.Procedimentos> LstProcedimentos { get; set; } = new();
        public Procedimentos_Metodo()
        {
            LstProcedimentos.Add(new Entidades.Procedimentos() { Id = 1, Tipo = "Consulta", Valor = 100.00});
            LstProcedimentos.Add(new Entidades.Procedimentos() { Id = 2, Tipo = "Exame", Valor = 200.00 });
            LstProcedimentos.Add(new Entidades.Procedimentos() { Id = 3, Tipo = "Cirurgia", Valor = 1000.00 });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class FormaPgto_Metodo
    {
        public List<Entidades.FormaPgto> LstFormaPgto { get; set; } = new();
        public FormaPgto_Metodo()
        {
            LstFormaPgto.Add(new Entidades.FormaPgto() { Id = 1, Tipo = "Convênio" });
            LstFormaPgto.Add(new Entidades.FormaPgto() { Id = 2, Tipo = "Particular" });
        }
    }
}

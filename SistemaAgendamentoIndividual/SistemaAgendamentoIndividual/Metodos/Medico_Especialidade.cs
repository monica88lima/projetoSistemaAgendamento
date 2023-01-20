using SistemaAgendamentoIndividual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class Medico_Especialidade
    {
        public List<Entidades.Medico_Especialidade> LstMedico_Especialidade { get; set; } = new();

        public Medico_Especialidade()
        {
            var random = new Random();
            for (int i = 1; i <= 25; i++)
            {                
                var medicoId = random.Next(1, 42);
                LstMedico_Especialidade.Add(new Entidades.Medico_Especialidade() { Id = i, EspecialidadeId = i, MedicoId = medicoId });
            }

        }
        public void Filtro(int id_especialidade,int id_medico)
        {
            //onde x é a classe. classe tem a propriedade id que e usada para localizar o procedimento
            var filtroMedico = LstMedico_Especialidade.Where(x => x.EspecialidadeId == id_especialidade && x.MedicoId == id_medico ).ToList();

            
        }
        
    }
}

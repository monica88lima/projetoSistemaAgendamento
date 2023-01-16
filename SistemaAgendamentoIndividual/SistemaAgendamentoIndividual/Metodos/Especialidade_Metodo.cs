using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
   public class Especialidade_Metodo
    {
        public List<Entidades.Especialidades> LstEspecialidades_Consulta { get; set; } = new();
        public List<Entidades.Especialidades> LstEspecialidades_Cirurgia { get; set; } = new();
        public List<Entidades.Especialidades> LstEspecialidades_Exames { get; set; } = new();

        public Especialidade_Metodo()
        {
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 1, Nome = "Acupuntura"});
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 2, Nome = "Cardiologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 3, Nome = "Dermatologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 4, Nome = "Ginecologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 5, Nome = "Infectologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 6, Nome = "Neurologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 7, Nome = "Otorrinolaringolista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 8, Nome = "Oftalmologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 9, Nome = "Ortopedista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 10, Nome = "Pediatra" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 11, Nome = "Pneumologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 12, Nome = "Reumatologista" });
            LstEspecialidades_Consulta.Add(new Entidades.Especialidades() { Id = 13, Nome = "Urologista" });

            LstEspecialidades_Cirurgia.Add(new Entidades.Especialidades() { Id = 1, Nome = "Cirurgia Geral" });
            LstEspecialidades_Cirurgia.Add(new Entidades.Especialidades() { Id = 2, Nome = "Cirurgia Cardiovascular" });
            LstEspecialidades_Cirurgia.Add(new Entidades.Especialidades() { Id = 3, Nome = "Cirurgia Pediátrica" });
            LstEspecialidades_Cirurgia.Add(new Entidades.Especialidades() { Id = 4, Nome = "Cirurgia Vascular" });
            LstEspecialidades_Cirurgia.Add(new Entidades.Especialidades() { Id = 5, Nome = "Cirurgia Plástica" });

            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 1, Nome = "Patologia clínica/medicina laboratorial" });
            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 2, Nome = "Eletrocardiograma" });
            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 3, Nome = "Ultrassom" });
            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 4, Nome = "Ressonância" });
            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 5, Nome = "Raio X" });
            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 6, Nome = "Tomografia" });
            LstEspecialidades_Exames.Add(new Entidades.Especialidades() { Id = 7, Nome = "Endoscopia" });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class Medicos_Metodo
    {
        public List<Entidades.Medicos> LstMedicos { get; set; } = new();

        public Medicos_Metodo()
        {
            LstMedicos.Add(new Entidades.Medicos() { Id= 1,Id_Procedimento = 1,Nome_Procedimento = "Consulta",Id_Especialidade = 1, Nome_Especialidade = "Acupuntura", Nome = "João Antônio Nobrega", Crm = 3520 });
            LstMedicos.Add(new Entidades.Medicos() { Id= 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 1, Nome_Especialidade = "Acupuntura", Nome = "Ana Gomes", Crm = 3221 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 2, Nome_Especialidade = "Cardiologista", Nome = "Francisco Manoel Nobrega", Crm = 3401 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 2, Nome_Especialidade = "Cardiologista", Nome = "Ana Beatriz Dias" , Crm = 3498 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 3, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 2, Nome_Especialidade = "Cardiologista", Nome = "Luana Oliveira", Crm = 3421 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 3, Nome_Especialidade = "Dermatologista", Nome = "Miguel Martins", Crm = 3579 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 3, Nome_Especialidade = "Dermatologista", Nome = "Roberta Mendes", Crm = 3556 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 3, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 3, Nome_Especialidade = "Dermatologista", Nome = "Eduarda Oliveira", Crm = 3537 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 4, Nome_Especialidade = "Ginecologista", Nome = "Yasmim Albuquerque", Crm = 3920 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 4, Nome_Especialidade = "Ginecologista", Nome = "Samuel Coimbra", Crm = 3921 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 5, Nome_Especialidade = "Infectologista", Nome = "Leticia Almeida Castro", Crm = 3610 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 5, Nome_Especialidade = "Infectologista", Nome = "Nicolas Veiga", Crm = 3621 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 6, Nome_Especialidade = "Neurologista", Nome = "Manuel Fonseca", Crm = 3789 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 6, Nome_Especialidade = "Neurologista", Nome = "Arthur Henrique Mendes Costa", Crm = 3556 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 3, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 6, Nome_Especialidade = "Neurologista", Nome = "Maria Paula Eduarda Oliveira Silva", Crm = 3597 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 7, Nome_Especialidade = "Otorrinolaringolista", Nome = "Antono Miguel Martins", Crm = 3279 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 7, Nome_Especialidade = "Otorrinolaringolista", Nome = "Roberta Maria Mendes", Crm = 3356 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 3, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 7, Nome_Especialidade = "Otorrinolaringolista", Nome = "Elis Eduarda Oliveira", Crm = 3137 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 8, Nome_Especialidade = "Oftalmologista", Nome = "Yasmim Mendes Albuquerque", Crm = 3920 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 8, Nome_Especialidade = "Oftalmologista", Nome = "Samuel Pereira Coimbra", Crm = 3921 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 9, Nome_Especialidade = "Ortopedista", Nome = "Guilherme Luz  Castro", Crm = 3610 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 9, Nome_Especialidade = "Ortopedista", Nome = "Bernardo Kauã Veiga", Crm = 3621 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 10, Nome_Especialidade = "Pediatra", Nome = "Giovany Mendes Albuquerque", Crm = 3920 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 10, Nome_Especialidade = "Pediatra", Nome = "Rafaella Pereira Coimbra", Crm = 3921 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 11, Nome_Especialidade = "Pneumologista", Nome = "Leticia Luz  Castro", Crm = 3610 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 11, Nome_Especialidade = "Pneumologista", Nome = "Kauã Santos", Crm = 3621 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 12, Nome_Especialidade = "Reumatologista", Nome = "Luiza Antony", Crm = 3920 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 12, Nome_Especialidade = "Reumatologista", Nome = "Samuel Pereira Coimbra", Crm = 3921 });

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 13, Nome_Especialidade = "Urologista", Nome = "Liz Silva", Crm = 3610 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Procedimento = 1, Nome_Procedimento = "Consulta", Id_Especialidade = 13, Nome_Especialidade = "Urologista", Nome = "Valentina Cardoso", Crm = 3621 });

        }
    }
}

using SistemaAgendamentoIndividual.Entidades;
using SistemaAgendamentoIndividual.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamentoIndividual.Metodos
{
    public class Agenda_Metodo : IAgenda
    {
        public void CriarAgendamento()
        {
            var usuario_pgto = new Metodos.FormaPgto_Metodo();
            int frmPgto = usuario_pgto.ExibirFormaPgto();

            var usuario_procedimento = new Metodos.Procedimentos_Metodo();
            int escolhaProced = usuario_procedimento.ExibirProcedimento();


            var usuario_especialidade = new Especialidade_Metodo();
            usuario_especialidade.Filtro(escolhaProced, frmPgto == 1, frmPgto == 2);
            int espec = usuario_especialidade.ColetarEspecialidade();


            var medico = new Medicos_Metodo();
            medico.Filtro(espec);
            int dr = medico.ColetarNomeMedico();


            var calendario = new Calendario_Metodo();
            calendario.ExibirCalendario(dr);
            var diaEHoraEscolhido = calendario.ColetarCalendario(dr);


            Agenda agendar = new Agenda();
            CreateInstance(dr,escolhaProced,espec,frmPgto,diaEHoraEscolhido);

            agendar.Id_Calendario = diaEHoraEscolhido.Id;


        }

        public static void CreateInstance(int dr, int escolhaProced, int espec,int frmPgto, Calendario diaEHoraEscolhido)
        {

            Type cType = typeof(Agenda);
            object consulta = Activator.CreateInstance(cType);

            PropertyInfo medicoProperty = cType.GetProperty("Id_Medico");
            PropertyInfo especialidadeProperty = cType.GetProperty("Id_Especialidade");
            PropertyInfo procedimentoProperty = cType.GetProperty("Id_procedimento");
            PropertyInfo formaPgtoProperty = cType.GetProperty("Id_FormaPgto");
            PropertyInfo calendaroProperty = cType.GetProperty("Id_Calendario");


            medicoProperty.SetValue(consulta, dr);
            especialidadeProperty.SetValue(consulta, escolhaProced);
            procedimentoProperty.SetValue(consulta, espec);
            formaPgtoProperty.SetValue(consulta, frmPgto);
            calendaroProperty.SetValue(consulta, diaEHoraEscolhido);


            MethodInfo displayInfoMethod = cType.GetMethod("DisplayInfo");
            displayInfoMethod.Invoke(consulta, null);

            DisplayPublicProperties(consulta);

        }

        public static void DisplayPublicProperties(object obj)
        {
            var tipo = obj.GetType();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Nome da Classe:" + tipo.Name);

            foreach (var prop in tipo.GetProperties())
            {
                builder.AppendLine(prop.Name + ": " + prop.GetValue(obj));
            }
            ImprimirLog(builder.ToString());
        }
        public static void ImprimirLog(string texto)
        {
            Console.WriteLine(texto);
        }


    }
}

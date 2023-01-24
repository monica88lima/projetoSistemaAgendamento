﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaAgendamentoIndividual.Entidades
{
    public  class Agenda:Base
    {
        public int Id_Medico { get; set; }
        public int Id_Especialidade { get; set; }
        public int Id_procedimento { get; set; }
        public int Id_FormaPgto { get; set; }
        
        public int Id_Calendario { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;


        public Agenda()
        {
            
            
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Id_Medico} - {Id_Especialidade} - {Id_procedimento} - {Id_FormaPgto}- {Id_Calendario} ");
        }
    }
}

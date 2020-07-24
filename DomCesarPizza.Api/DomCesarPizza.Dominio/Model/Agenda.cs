using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime DataInicio{ get; set; }
        public DateTime DataFim { get; set; }
        public List<AgendaCardapio> AgendaCardapio { get; set; }
    }
}

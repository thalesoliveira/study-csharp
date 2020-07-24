using DomCesarPizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Model
{
    public class Agenda : IEntity
    {
        public int Id { get; set; }
        public DateTime DataInicio{ get; set; }
        public DateTime DataFim { get; set; }
        public List<AgendaCardapio> AgendaCardapio { get; set; }
    }
}

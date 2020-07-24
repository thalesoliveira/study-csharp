using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Model
{
    public class AgendaCardapio
    {
        public int IdCardapio { get; set; }
        public Cardapio Cardapio { get; set; }
        public int IdAgenda { get; set; }
        public Agenda Agenda { get; set; }
        public int Id { get; set; }
    }
}

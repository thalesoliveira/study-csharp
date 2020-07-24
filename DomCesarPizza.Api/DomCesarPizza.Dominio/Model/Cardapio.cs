using DomCesarPizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Model
{
    public class Cardapio : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List <AgendaCardapio> AgendaCardapio { get; set; }

        public List <Pizza> Pizza { get; set; }
    }
}

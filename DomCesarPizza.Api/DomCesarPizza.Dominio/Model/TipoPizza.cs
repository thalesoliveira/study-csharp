using DomCesarPizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Model
{
    
    public class TipoPizza : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }

        public List<Pizza> Pizzas { get; set; }
    }
}

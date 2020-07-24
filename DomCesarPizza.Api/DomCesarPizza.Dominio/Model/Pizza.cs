using DomCesarPizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Model
{
    public class Pizza : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int IdTipoPizza { get; set; }
        public TipoPizza TipoPizza { get; set; }
        public List<PizzaIngredientes> PizzaIngredientes { get; set; }
    }
}

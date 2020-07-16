using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Modelo
{
    public class Pizza
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

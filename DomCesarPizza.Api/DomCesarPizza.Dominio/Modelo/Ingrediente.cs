using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Modelo
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public DateTime Validade { get; set; }

        public List<PizzaIngredientes> PizzaIngredientes{ get; set; }
    }
}

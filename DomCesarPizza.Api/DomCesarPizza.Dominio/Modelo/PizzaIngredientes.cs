using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Modelo
{
    public class PizzaIngredientes
    {
        public int Id { get; set; }
        public int IdPizza { get; set; }
        public Pizza Pizza { get; set; }
        public int IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }

    }
}

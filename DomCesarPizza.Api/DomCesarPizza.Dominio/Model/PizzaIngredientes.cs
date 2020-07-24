using DomCesarPizza.Domain.Interfaces;

namespace DomCesarPizza.Domain.Model
{
    public class PizzaIngredientes : IEntity
    {
        public int Id { get; set; }
        public int IdPizza { get; set; }
        public Pizza Pizza { get; set; }
        public int IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }

    }
}

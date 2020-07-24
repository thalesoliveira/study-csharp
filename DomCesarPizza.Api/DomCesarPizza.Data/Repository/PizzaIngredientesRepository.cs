using DomCesarPizza.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class PizzaIngredientesRepository
    {
        
        public List<PizzaIngredientes> getAll()
        {
            using (var contexto = new Contexto())
            {
                return contexto.PizzaIngredientes.ToList();
            }
        }

        public void create(PizzaIngredientes pizzaIngrediente)
        {
            using (var contexto = new Contexto())
            {
                contexto.PizzaIngredientes.Add(pizzaIngrediente);
                contexto.SaveChanges();
            }
        }

        public void update(PizzaIngredientes pizzaIngrediente)
        {
            using (var contexto = new Contexto())
            {
                contexto.PizzaIngredientes.Update(pizzaIngrediente);
                contexto.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.PizzaIngredientes.FirstOrDefault(x => x.Id == id);
                contexto.PizzaIngredientes.Remove(entity);
                contexto.SaveChanges();
            }
        }

        public PizzaIngredientes findById(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Pizza.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}

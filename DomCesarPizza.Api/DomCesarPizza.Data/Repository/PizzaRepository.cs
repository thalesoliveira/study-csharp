using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class PizzaRepository
    {

        public List<Pizza> getAll()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Pizza.ToList();
            }
        }

        public void create(Pizza pizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.Pizza.Add(pizza);
                contexto.SaveChanges();
            }
        }

        public void update(Pizza pizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.Pizza.Update(pizza);
                contexto.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.Pizza.FirstOrDefault(x => x.Id == id);
                contexto.Pizza.Remove(entity);
                contexto.SaveChanges();
            }
        }
        public Pizza findById(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Pizza.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}

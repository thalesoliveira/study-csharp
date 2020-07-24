using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class TipoPizzaRepository
    {
        public List<TipoPizza> getAll()
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPizza.ToList();
            }
        }

        public void create(TipoPizza tipoPizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPizza.Add(tipoPizza);
                contexto.SaveChanges();
            }
        }

        public void update(TipoPizza tipoPizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPizza.Update(tipoPizza);
                contexto.SaveChanges();
            }
        }
        public void delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.TipoPizza.FirstOrDefault(x => x.Id == id);
                contexto.TipoPizza.Remove(entity);
                contexto.SaveChanges();
            }
        }

        public TipoPizza findById(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPizza.FirstOrDefault(x => x.Id == id);
            }
        }

    }
}

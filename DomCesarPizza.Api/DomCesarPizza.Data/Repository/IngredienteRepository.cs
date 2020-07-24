using DomCesarPizza.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class IngredienteRepository
    {
        public List<Ingrediente> getAll()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Ingrediente.ToList();
            }
        }

        public void create(Ingrediente ingrediente)
        {
            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Add(ingrediente);
                contexto.SaveChanges();
            }
        }

        public void update(Ingrediente ingrediente)
        {
            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Update(ingrediente);
                contexto.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
                contexto.Ingrediente.Remove(entity);
                contexto.SaveChanges();
            }
        }

        public Ingrediente findById(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}

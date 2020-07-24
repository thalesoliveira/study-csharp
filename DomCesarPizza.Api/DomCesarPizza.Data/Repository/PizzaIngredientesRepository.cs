using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class PizzaIngredientesRepository : RepositoryBase<PizzaIngredientes>, Domain.Interfaces.IPizzaIngredientesRepository
    {
        public PizzaIngredientesRepository(Contexto contexto) : base(contexto)
        {

        }

    }
}

using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class PizzaRepository : RepositoryBase<Pizza>, IPizzaRepository
    {
        public PizzaRepository(Contexto contexto) : base(contexto)
        {

        }
        
    }
}

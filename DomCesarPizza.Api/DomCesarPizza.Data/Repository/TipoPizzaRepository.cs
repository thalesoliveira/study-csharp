using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class TipoPizzaRepository : RepositoryBase<TipoPizza>, ITipoPizzaRepository
    {
       
        public TipoPizzaRepository(Contexto contexto) : base(contexto)
        {

        }

    }
}

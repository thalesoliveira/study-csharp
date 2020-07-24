
using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class IngredienteRepository : RepositoryBase<Ingrediente>, IIngredienteRepository
    {

        public IngredienteRepository(Contexto contexto) : base(contexto)
        {

        }
       
    }
}

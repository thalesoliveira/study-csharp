using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class CardapioRepository : RepositoryBase<Cardapio>, ICardapioRepository
    {
        public CardapioRepository(Contexto contexto) : base(contexto)
        {

        }
        
    }
}

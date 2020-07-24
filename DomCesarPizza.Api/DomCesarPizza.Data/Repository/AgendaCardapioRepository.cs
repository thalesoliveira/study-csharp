using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class AgendaCardapioRepository : RepositoryBase<AgendaCardapio>, IAgendaCardapioRepository
    {
        public AgendaCardapioRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}

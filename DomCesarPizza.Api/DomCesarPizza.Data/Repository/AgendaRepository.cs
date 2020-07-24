using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class AgendaRepository : RepositoryBase<Agenda>, IAgendaRepository
    {
        public AgendaRepository(Contexto contexto) : base(contexto)
        {

        }

    }
}

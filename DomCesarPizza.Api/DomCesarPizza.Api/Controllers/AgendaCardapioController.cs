using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomCesarPizza.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaCardapioController : ControllerBase
    {

        private readonly IAgendaCardapioRepository _repository;

        public AgendaCardapioController(IAgendaCardapioRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<AgendaCardapioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<AgendaCardapioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<AgendaCardapioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<AgendaCardapioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<AgendaCardapioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

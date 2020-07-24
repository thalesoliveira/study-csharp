using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomCesarPizza.Data;
using DomCesarPizza.Data.Repository;
using DomCesarPizza.Domain.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPizzaController : ControllerBase
    {

        private TipoPizzaRepository _repository;
        public TipoPizzaController()
        {
            _repository = new TipoPizzaRepository();
        }


        // GET: api/<TipoPizzaController>
        [HttpGet]
        public IEnumerable<TipoPizza> Get()
        {
            return _repository.getAll();
        }

        // GET api/<TipoPizzaController>/5
        [HttpGet("{id}")]
        public TipoPizza Get(int id)
        {
            return _repository.findById(id);
        }

        // POST api/<TipoPizzaController>
        [HttpPost]
        public IEnumerable<TipoPizza> Post([FromBody] TipoPizza tipoPizza)
        {
            _repository.create(tipoPizza);
            return _repository.getAll();
        }

        // PUT api/<TipoPizzaController>/5
        [HttpPut]
        public IEnumerable<TipoPizza> Put(int id, [FromBody] TipoPizza tipoPizza)
        {
            _repository.update(tipoPizza);
            return _repository.getAll();
        }

        // DELETE api/<TipoPizzaController>/5
        [HttpDelete("{id}")]
        public IEnumerable<TipoPizza> Delete(int id)
        {
            _repository.delete(id);
            return _repository.getAll();
        }
    }
}

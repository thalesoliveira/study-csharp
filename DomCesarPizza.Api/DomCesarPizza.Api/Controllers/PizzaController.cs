using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomCesarPizza.Data;
using DomCesarPizza.Data.Repository;
using DomCesarPizza.Domain.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {

        private PizzaRepository _repository;

        public PizzaController()
        {
            _repository = new PizzaRepository();
        }

        // GET: api/<PizzaController>
        [HttpGet]
        public IEnumerable<Pizza> Get()
        {          
            return _repository.getAll();
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return _repository.findById(id);         
        }

        // POST api/<PizzaController>
        [HttpPost]
        public IEnumerable<Pizza> Post([FromBody] Pizza pizza)
        {
            _repository.create(pizza);
            return _repository.getAll();
        }

        // PUT api/<PizzaController>/5
        [HttpPut]
        public IEnumerable<Pizza> Put(int id, [FromBody] Pizza pizza)
        {        
            _repository.update(pizza);
            return _repository.getAll();
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Pizza> Delete(int id)
        {
            _repository.delete(id);
           return _repository.getAll();
        }
    }
}

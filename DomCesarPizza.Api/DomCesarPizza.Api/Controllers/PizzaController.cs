using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomCesarPizza.Data;
using DomCesarPizza.Data.Repository;
using DomCesarPizza.Domain.Interfaces;
using DomCesarPizza.Domain.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {

        private readonly IPizzaRepository _repository;
        public PizzaController(IPizzaRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<PizzaController>
        [HttpGet]
        public IEnumerable<Pizza> Get()
        {          
            return _repository.GetAll();
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return _repository.FindById(id);         
        }

        // POST api/<PizzaController>
        [HttpPost]
        public IEnumerable<Pizza> Post([FromBody] Pizza pizza)
        {
            _repository.Create(pizza);
            return _repository.GetAll();
        }

        // PUT api/<PizzaController>/5
        [HttpPut]
        public IEnumerable<Pizza> Put(int id, [FromBody] Pizza pizza)
        {        
            _repository.Update(pizza);
            return _repository.GetAll();
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Pizza> Delete(int id)
        {
            _repository.Delete(id);
           return _repository.GetAll();
        }
    }
}

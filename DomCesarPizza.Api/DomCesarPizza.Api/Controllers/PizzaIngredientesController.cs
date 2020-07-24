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
    public class PizzaIngredientesController : ControllerBase
    {

        private readonly IPizzaIngredientesRepository _repository;
        public PizzaIngredientesController(IPizzaIngredientesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<PizzaIngredientesController>
        [HttpGet]
        public IEnumerable<PizzaIngredientes> Get()
        {
           return _repository.getAll();
        }

        // GET api/<PizzaIngredientesController>/5
        [HttpGet("{id}")]
        public PizzaIngredientes Get(int id)
        {
            return _repository.findById(id);
        }

        // POST api/<PizzaIngredientesController>
        [HttpPost]
        public IEnumerable<PizzaIngredientes> Post([FromBody] PizzaIngredientes pizzaIngredientes)
        {
            _repository.create(pizzaIngredientes);
            return _repository.getAll();
        }

        // PUT api/<PizzaIngredientesController>/5
        [HttpPut]
        public IEnumerable<PizzaIngredientes> Put([FromBody] PizzaIngredientes pizzaIngredientes)
        {
            if (pizzaIngredientes is null)
            {
                throw new ArgumentNullException(nameof(pizzaIngredientes));
            }

            _repository.update(pizzaIngredientes);
            return _repository.getAll();
        }

        // DELETE api/<PizzaIngredientesController>/5
        [HttpDelete("{id}")]
        public IEnumerable<PizzaIngredientes> Delete(int id)
        {
            _repository.delete(id);
            return _repository.getAll();
        }
    }
}

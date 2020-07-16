using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomCesarPizza.Data;
using DomCesarPizza.Domain.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaIngredientesController : ControllerBase
    {
        // GET: api/<PizzaIngredientesController>
        [HttpGet]
        public IEnumerable<PizzaIngredientes> Get()
        {
            using (var contexto = new Contexto())
            {
                return contexto.PizzaIngredientes.ToList();
            }
        }

        // GET api/<PizzaIngredientesController>/5
        [HttpGet("{id}")]
        public PizzaIngredientes Get(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.PizzaIngredientes.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<PizzaIngredientesController>
        [HttpPost]
        public IEnumerable<PizzaIngredientes> Post([FromBody] PizzaIngredientes pizzaIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PizzaIngredientes.Add(pizzaIngredientes);
                contexto.SaveChanges();
                return contexto.PizzaIngredientes.ToList();
            }
        }

        // PUT api/<PizzaIngredientesController>/5
        [HttpPut]
        public IEnumerable<PizzaIngredientes> Put([FromBody] PizzaIngredientes pizzaIngredientes)
        {
            if (pizzaIngredientes is null)
            {
                throw new ArgumentNullException(nameof(pizzaIngredientes));
            }

            using (var contexto = new Contexto())
            {
                contexto.PizzaIngredientes.Update(pizzaIngredientes);
                contexto.SaveChanges();
                return contexto.PizzaIngredientes.ToList();
            }
        }

        // DELETE api/<PizzaIngredientesController>/5
        [HttpDelete("{id}")]
        public IEnumerable<PizzaIngredientes> Delete(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.PizzaIngredientes.FirstOrDefault(x => x.Id == id);
                contexto.PizzaIngredientes.Remove(entity);
                contexto.SaveChanges();
                return contexto.PizzaIngredientes.ToList();
            }
        }
    }
}

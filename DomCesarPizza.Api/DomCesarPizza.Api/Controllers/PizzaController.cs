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
    public class PizzaController : ControllerBase
    {
        // GET: api/<PizzaController>
        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Pizza.ToList();
            }
                 
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Pizza.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<PizzaController>
        [HttpPost]
        public IEnumerable<Pizza> Post([FromBody] Pizza pizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.Pizza.Add(pizza);
                contexto.SaveChanges();
                return contexto.Pizza.ToList();
            }

        }

        // PUT api/<PizzaController>/5
        [HttpPut]
        public IEnumerable<Pizza> Put(int id, [FromBody] Pizza pizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.Pizza.Update(pizza);
                contexto.SaveChanges();
                return contexto.Pizza.ToList();
            }
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Pizza> Delete(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.Pizza.FirstOrDefault(x => x.Id == id);
                contexto.Pizza.Remove(entity);
                contexto.SaveChanges();
                return contexto.Pizza.ToList();
            }

        }
    }
}

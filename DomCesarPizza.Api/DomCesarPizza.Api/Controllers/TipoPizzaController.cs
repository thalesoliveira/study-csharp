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
    public class TipoPizzaController : ControllerBase
    {
        // GET: api/<TipoPizzaController>
        [HttpGet]
        public IEnumerable<TipoPizza> Get()
        {
            
            using (var contexto = new Contexto())
            {
                return contexto.TipoPizza.ToList();
            }
        }

        // GET api/<TipoPizzaController>/5
        [HttpGet("{id}")]
        public TipoPizza Get(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPizza.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<TipoPizzaController>
        [HttpPost]
        public IEnumerable<TipoPizza> Post([FromBody] TipoPizza tipoPizza)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPizza.Add(tipoPizza);
                contexto.SaveChanges();
                return contexto.TipoPizza.ToList();
            }
        }

        // PUT api/<TipoPizzaController>/5
        [HttpPut]
        public IEnumerable<TipoPizza> Put(int id, [FromBody] TipoPizza tipoPizza)
        {
            using (var contexto = new Contexto())
            {   
                contexto.TipoPizza.Update(tipoPizza);
                contexto.SaveChanges();
                return contexto.TipoPizza.ToList();
            }
        }

        // DELETE api/<TipoPizzaController>/5
        [HttpDelete("{id}")]
        public IEnumerable<TipoPizza> Delete(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.TipoPizza.FirstOrDefault(x => x.Id == id);
                contexto.TipoPizza.Remove(entity);
                contexto.SaveChanges();
                return contexto.TipoPizza.ToList();
            }
        }
    }
}

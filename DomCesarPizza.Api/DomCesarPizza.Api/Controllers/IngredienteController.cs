using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomCesarPizza.Domain.Modelo;
using DomCesarPizza.Data;
using System.Runtime.InteropServices.WindowsRuntime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {

        /*List<Ingrediente> ingredientes;

        public IngredienteController()
        {
            ingredientes = new List<Ingrediente>();
        }*/    
        
        // GET: api/<IngredienteController>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Ingrediente.ToList();
            }
            
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {
            //ingredientes.Add(ingrediente);
            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Add(ingrediente);
                contexto.SaveChanges();
                return contexto.Ingrediente.ToList();
            }
            //return ingredientes;
        }

        // PUT api/<IngredienteController>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put(int id, [FromBody] Ingrediente ingrediente)
        {
            //int index = ingredientes.FindIndex(x => x.Id == id);

            //if (index > -1)
            //{
            //    ingredientes[index].Nome = ingrediente.Nome;
            //    ingredientes[index].Descricao = ingrediente.Descricao;
            //    ingredientes[index].Validade = ingrediente.Validade;
            //}
            //return ingredientes;

            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Update(ingrediente);
                contexto.SaveChanges();
                return contexto.Ingrediente.ToList();
            }
        }

        // DELETE api/<IngredienteController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            //var ingrediente = ingredientes.FirstOrDefault(x => x.Id == id);
            //if (ingrediente == null) 
            //    ingredientes.Remove(ingrediente);
            //return ingredientes;
            using (var contexto = new Contexto())
            {
                var entity = contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
                contexto.Ingrediente.Remove(entity);
                contexto.SaveChanges();
                return contexto.Ingrediente.ToList();
            }
        }
    }
}

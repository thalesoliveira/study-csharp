using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomCesarPizza.Domain.Modelo;
using DomCesarPizza.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using DomCesarPizza.Data.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {

        private IngredienteRepository _repository;

        public IngredienteController()
        {
            _repository = new IngredienteRepository();
        }
        
        // GET: api/<IngredienteController>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repository.getAll();            
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repository.findById(id);       
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {            
            _repository.create(ingrediente);
            return _repository.getAll();
        }

        // PUT api/<IngredienteController>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put(int id, [FromBody] Ingrediente ingrediente)
        {           
            _repository.update(ingrediente);
            return _repository.getAll();
        }

        // DELETE api/<IngredienteController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            _repository.delete(id);
            return _repository.getAll();
        }
    }
}

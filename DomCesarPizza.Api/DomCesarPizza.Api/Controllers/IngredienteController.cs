using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomCesarPizza.Domain.Model;
using DomCesarPizza.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using DomCesarPizza.Data.Repository;
using DomCesarPizza.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomCesarPizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {

        private readonly IIngredienteRepository _repository;

        public IngredienteController(IIngredienteRepository repository)
        {
            _repository = repository;
        }
        
        // GET: api/<IngredienteController>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repository.GetAll();            
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repository.FindById(id);       
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {            
            _repository.Create(ingrediente);
            return _repository.GetAll();
        }

        // PUT api/<IngredienteController>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put(int id, [FromBody] Ingrediente ingrediente)
        {           
            _repository.Update(ingrediente);
            return _repository.GetAll();
        }

        // DELETE api/<IngredienteController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            _repository.Delete(id);
            return _repository.GetAll();
        }
    }
}

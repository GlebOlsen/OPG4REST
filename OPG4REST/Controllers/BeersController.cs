using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBG1;
using OPG4REST.Managers;

namespace OPG4REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeersManager _manager = new BeersManager();
        // GET: api/<BeersController>
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return _manager.Getall();
        }

        // GET api/<BeersController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return _manager.GetId(id);
        }

        // POST api/<BeersController>
        [HttpPost]
        public void Post([FromBody] Beer value)
        {
            _manager.Add(value);
        }

        // PUT api/<BeersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Beer value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<BeersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjDotNetMongo.Model;
using ProjDotNetMongo.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjDotNetMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonPhysicalService _personService;

        public PersonController(PersonPhysicalService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<Physical>> Get() =>
            _personService.Get();

        [HttpGet("{id}", Name = "GetPerson")]
        public ActionResult<Physical> Get(string id)
        {
            var person = _personService.Get(id);

            if(person == null)
                return NotFound();

            return person;
        }

        [HttpPost]
        public ActionResult<Physical> Create(Physical person) 
        { 
            _personService.Create(person);

            return CreatedAtRoute("GetPerson", new { id = person.Id}, person);
        }

        [HttpPut("{id}")]

        public IActionResult Update(string id, Physical person)
        {
            _personService.Update(id, person);

            return CreatedAtRoute("GetPerson", new { id = person.Id }, person);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var person = _personService.Get(id);
            
            if (person == null)
                return NotFound();
            
            _personService.Remove(person);

            return NoContent();
        }
        
    }
}

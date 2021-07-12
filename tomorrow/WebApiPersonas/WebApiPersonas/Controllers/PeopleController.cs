using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPersonas.Data;
using WebApiPersonas.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        //siempre configuramos una propiedad de solo lectura para trabajar con mi EF especial 
        private readonly ApplicationDbContext _context;
        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            //usamos EF para traer a las personas
            return _context.People.ToList();
        }


        //para retornar un objeto usamos el tipo ActionResult<Person> y usamos EF para buscar la persona por ID
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            //usamos EF para traer a las personas
            return _context.People.Find(id);
        }

        //insertar
        [HttpPost("{id}")]
        public ActionResult Post(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerPersona", new { id = person.Id }, person);
        }


        [HttpGet("ObtenerPersona/{id}", Name = "ObtenerPersona")]
        public ActionResult<Person> ObtenerPersona(int id)
        {
            return _context.People.Find(id);
        }


        //api/people/id
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Person person)
        {
            if(id != person.Id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(int id)
        {
            var person = _context.People.Find(id);

            if(person == null)
            {
                return NotFound();
            }

            _context.People.Remove(person);
            _context.SaveChanges();

            return person;
        }

        //usar rutas personalizadas
        //api/people/TrearApellido/giles
        //GET: api/people/TrearApellido/g
        [HttpGet("TraerApellido/{lname}")]
        //[HttpGet("{nombre}")] //NO VA A funcionar porque ya tenemos un Get por parametro
        public IEnumerable<Person> GetByName(string lname)
        {
            var person = (from p in _context.People
                          where p.LastName.Contains(lname)
                          //where p.LastName== nombre
                          select p).ToList();

            return person;
        }

    }
}
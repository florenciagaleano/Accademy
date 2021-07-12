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
        [HttpPost]
        public ActionResult Post(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerPersona", new { id = person.Id }, person);
        }

    }
}


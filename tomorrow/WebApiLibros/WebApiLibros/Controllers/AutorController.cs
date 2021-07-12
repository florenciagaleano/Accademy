using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibros.Contexto;
using WebApiLibros.Entidades;

namespace WebApiLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public AutorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return context.Autores.ToList();
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id)
        {
            var resultado = context.Autores.FirstOrDefault(x => x.Id == id);
            if (resultado == null)
            { return NotFound(); }
            return resultado;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            context.Autores.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new
            {
                id =
            autor.Id
            }, autor);
        }


    }
}

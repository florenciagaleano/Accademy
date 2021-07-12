using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPubs.Models;

namespace WebApiPubs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly PubsContext _context;
        public PublisherController(PubsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            return _context.Publishers.ToList();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebPlatformAPI.Angular.Context;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Controllers
{   
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return context.clientes.ToList();

            //return Ok(cliente);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebPlatformAPI.Angular.Context;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Controllers
{
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "Test")]
        public ActionResult<Cliente> Get()
        {
            var cliente = context.clientes.ToList();

            return Ok(cliente);
        }
    }
}

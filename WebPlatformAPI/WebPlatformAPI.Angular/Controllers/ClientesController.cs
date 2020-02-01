using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformAPI.Angular.Context;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        #region Ctor
        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        } 
        #endregion

        #region GetAll
        //Devuelve Todos los Clientes
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            var clietes = await context.clientes.ToListAsync();

            return Ok(clietes);
        }
        #endregion

        #region GetOne
        //Devueve Un solo Cliente
        [HttpGet("{id}", Name = "ObtenerCliente")]
        public async Task<ActionResult<Cliente>> Get(int id)
        {
            var cliente = await context.clientes.FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }
        #endregion

        #region Post

        // Crea Cliente
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Cliente cliente)
        {
            context.Add(cliente);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("ObtenerCliente", new { id = cliente.Id }, cliente);
        }
        #endregion

        #region Put 
        // PUT Actualiza un Clliente
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cliente cliente)
        {
            cliente.Id = id;
            context.Entry(cliente).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region Delete

        // DELETE Borra un Cliente
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cliente>> Delete(int id)
        {
            var ClienteId = await context.clientes.Select(x => x.Id).FirstOrDefaultAsync(x => x == id);

            if (ClienteId == default(int))
            {
                return NotFound();
            }

            context.Remove(new Cliente { Id = ClienteId });
            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPlatformAPI.Angular.Context;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GarantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GarantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region GetAll
        //Devuelve Todos los Garantes
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Garante>>> Get()
        {
            var garante = await _context.Empresas.ToListAsync();

            return Ok(garante);
        }
        #endregion

        #region Get
        //Devueve un solo Garante
        [HttpGet("{id}", Name = "ObtenerGarante")]
        public async Task<ActionResult<Garante>> Get(int id)
        {
            var garante = await _context.Garantes.FirstOrDefaultAsync(x => x.Id == id);

            if (garante == null)
            {
                return NotFound();
            }

            return garante;
        }
        #endregion

        #region Post

        // Crea un Garante
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Garante garante)
        {
            _context.Add(garante);
            await _context.SaveChangesAsync();
            return new CreatedAtRouteResult("ObtenerGarante", new { id = garante.Id }, garante);
        }
        #endregion

        #region Put 
        // PUT Actualiza un Garante
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Garante garante)
        {
            garante.Id = id;
            _context.Entry(garante).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region Delete

        // DELETE Borra un Garante
        [HttpDelete("{id}")]
        public async Task<ActionResult<Empresa>> Delete(int id)
        {
            var idGarante = await _context.Garantes.Select(x => x.Id).FirstOrDefaultAsync(x => x == id);

            if (idGarante == default(int))
            {
                return NotFound();
            }

            _context.Remove(new Garante { Id = idGarante });
            await _context.SaveChangesAsync();
            return NoContent();
        }

        #endregion
    }
}
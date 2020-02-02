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
    public class EmpresasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmpresasController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region GetAll
        //Devuelve Todos los Clientes
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Empresa>>> Get()
        {
            var empresa = await _context.Empresas.ToListAsync();

            return Ok(empresa);
        }
        #endregion

        #region Get
        //Devueve Un solo Cliente
        [HttpGet("{id}", Name = "ObtenerEmpresa")]
        public async Task<ActionResult<Empresa>> Get(int id)
        {
            var empresa = await _context.Empresas.FirstOrDefaultAsync(x => x.Id == id);

            if (empresa == null)
            {
                return NotFound();
            }

            return empresa;
        }
        #endregion

        #region Post

        // Crea Empresa
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Empresa empresa)
        {
            _context.Add(empresa);
            await _context.SaveChangesAsync();
            return new CreatedAtRouteResult("ObtenerEmpresa", new { id = empresa.Id }, empresa);
        }
        #endregion

        #region Put 
        // PUT Actualiza una Empresa
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Empresa empresa)
        {
            empresa.Id = id;
            _context.Entry(empresa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region Delete

        // DELETE Borra una Empresa
        [HttpDelete("{id}")]
        public async Task<ActionResult<Empresa>> Delete(int id)
        {
            var idEmpresa = await _context.Empresas.Select(x => x.Id).FirstOrDefaultAsync(x => x == id);

            if (idEmpresa == default(int))
            {
                return NotFound();
            }

            _context.Remove(new Empresa { Id = idEmpresa });
            await _context.SaveChangesAsync();
            return NoContent();
        }

        #endregion
    }
}
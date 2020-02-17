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
    public class UserController:ControllerBase
    {
        private readonly ApplicationDbContext _context;

        #region Ctor
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region GetAll
        //Devuelve Todos los Usuario
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var user = await _context.Users.ToListAsync();

            return Ok(user);
        }
        #endregion

        #region GetOne
        //Devueve Un solo Usuario
        [HttpGet("{id}", Name = "ObtenerUser")]
        public async Task<ActionResult<User>> Get(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        #endregion

        #region Post

        // Crea Usuario
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return new CreatedAtRouteResult("ObtenerUser", new { id = user.Id }, user);
        }
        #endregion

        #region Put 
        // PUT Actualiza un Usuario
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] User user)
        {
            user.Id = id;
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region Delete

        // DELETE Borra un Cliente
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(string id)
        {
            var userId = await _context.Users.Select(x => x.Id).FirstOrDefaultAsync(x => x == id);

            if (userId == default(string))
            {
                return NotFound();
            }

            _context.Remove(new User { Id = userId });
            await _context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

    }
}

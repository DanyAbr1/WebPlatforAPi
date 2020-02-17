using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPlatformAPI.Angular.Context;
using WebPlatformAPI.Angular.Helppers;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController:ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserHelper _userHelpers;


        public AccountController(ApplicationDbContext context, IUserHelper userHelpers)
        {
            _context = context;
            _userHelpers = userHelpers;
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
           
                var result = await _userHelpers.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "User or password not valid.");
                model.Password = string.Empty;
            

            return Ok(model);
        }
    }
}

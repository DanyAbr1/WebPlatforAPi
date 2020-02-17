using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Helppers
{
    public interface IUserHelper
    {
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}

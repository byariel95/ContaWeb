using ContaWeb.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaWeb.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByNick(string nick);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}

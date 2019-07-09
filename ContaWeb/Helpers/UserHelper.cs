
namespace ContaWeb.Helpers
{
    using System;
    using System.Threading.Tasks;
    using ContaWeb.Data.Entities;
    using Microsoft.AspNetCore.Identity;

    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;

        public UserHelper( UserManager<User>userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);


        }
        // demo para iniciar session con user 
        public async Task<User> GetUserByNick(string iduser)
        {
            var user = await this.userManager.FindByIdAsync(iduser);
            return user;
        }
    }
}

using AccountMenager.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AccountMenager.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Login(LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Email);
            SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            if (signInResult.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Register(RegisterViewModel model)
        {
            User user = new(){ UserName = model.Email, Email = model.Email};
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

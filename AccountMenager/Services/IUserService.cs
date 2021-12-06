using AccountMenager.Models.Identity;
using System.Threading.Tasks;

namespace AccountMenager.Services
{
    public interface IUserService
    {
        public Task<bool> Login(LoginViewModel model);
        public Task<bool> Register(RegisterViewModel model);
        public Task<bool> Logout();
    }
}

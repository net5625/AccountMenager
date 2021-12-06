using AccountMenager.Models.Identity;
using AccountMenager.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AccountMenager.Controllers
{
    public class AccountController : Controller
    {
        public IUserService UserService { get; set; }

        public AccountController(IUserService _userService)
        {
            UserService = _userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await UserService.Register(model);
                if (result)
                {
                    return RedirectToAction("Index", "Panel");
                }
                else
                {
                    return View(model);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserService.Login(model);
                if (result)
                {
                    return RedirectToAction("Index", "Panel");
                }
                else
                {
                    return View(model);
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            var result = await UserService.Logout();
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }
        }
    }
}

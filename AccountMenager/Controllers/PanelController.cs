using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountMenager.Controllers
{
    public class PanelController : Controller
    {
        [HttpGet,
        Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}

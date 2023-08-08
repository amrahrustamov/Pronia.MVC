using Microsoft.AspNetCore.Mvc;

namespace Pronian.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

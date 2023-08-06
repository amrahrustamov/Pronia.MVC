using Microsoft.AspNetCore.Mvc;

namespace Pronian.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

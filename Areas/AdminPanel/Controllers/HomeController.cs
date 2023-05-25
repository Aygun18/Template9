using Microsoft.AspNetCore.Mvc;

namespace Template9.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

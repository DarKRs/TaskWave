using Microsoft.AspNetCore.Mvc;

namespace TaskWave.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVC1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

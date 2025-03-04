using Microsoft.AspNetCore.Mvc;

namespace Food_Truck.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

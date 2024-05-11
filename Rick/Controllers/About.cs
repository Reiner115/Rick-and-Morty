using Microsoft.AspNetCore.Mvc;

namespace Rick_And_Morty.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
